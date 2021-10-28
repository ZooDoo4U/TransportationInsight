using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SprocCallTestApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {

            InitializeComponent();

            txtServerName.Text = ReadConfigValue( "ServerName" );
            txtDatabaseName.Text = ReadConfigValue( "DatabaseName" );
            txtSchema.Text = ReadConfigValue( "DatabaseSchema" );
            txtSprocName.Text = ReadConfigValue( "StoredProcedure" );

            if(txtServerName.Text == null  ||
                txtDatabaseName.Text == null ||
                txtSchema.Text == null ||
                txtSprocName.Text == null)
            {
                MessageBox.Show( "Please fix up app.config with the value missing as prompted..." );
                this.Close();
            }      
        }

        //
        //  Read the connection setting for the database.
        //
        private string ReadConfigValue( string appSettingName ) 
        {
            try
            {
                //
                //  if null we force an error, throw the exception...
                //
                string appSetting = ConfigurationManager.AppSettings[appSettingName] ?? null;
                if( string.IsNullOrWhiteSpace( appSetting))
                {
                    MessageBox.Show($"Error reading {appSettingName}  from app.config");                
                    return null;
                }
                return appSetting;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error reading {appSettingName} from app.config.\n{ex.Message}");                
            }        
            return null; 
        }

        //
        //  The main routine to get the data from sql.
        //
        private void cmdFetchData_Click( object sender, EventArgs e )
        {
            if( string.IsNullOrWhiteSpace(this.txtDatabaseName.Text.Trim())  || 
                string.IsNullOrWhiteSpace(this.txtServerName.Text.Trim())  ||
                string.IsNullOrWhiteSpace(this.txtDatabaseName.Text.Trim()) || 
                string.IsNullOrWhiteSpace(this.txtSprocName.Text.Trim()) )
            {
                MessageBox.Show( "Please check all value for database are filled in..." );
                return ;  
            }
                   
            try
            {
                SqlConnectionStringBuilder cnStr = new SqlConnectionStringBuilder();
                cnStr.InitialCatalog = txtDatabaseName.Text.Trim();
                cnStr.DataSource = txtServerName.Text.Trim();
                cnStr.IntegratedSecurity = true;

                using(SqlConnection cn = new SqlConnection( cnStr.ConnectionString ))
                {
                    cn.Open();

                    using(SqlCommand cmd = new SqlCommand( $"[{txtSchema.Text.Trim()}].[{txtSprocName.Text.Trim()}]", cn ))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        var sqlParams = GetParamerForSproc( cn, txtSchema.Text, txtSprocName.Text) ; 
                        foreach( var param in sqlParams)
                        {
                            cmd.Parameters.Add(param);                               
                        }

                        using(SqlDataReader rd = cmd.ExecuteReader())
                        {                               
                            if( rd.HasRows ) 
                            {
                                SetupGrid(rd);                                
                            }
                            else
                            {
                                //
                                //  No rows get out...
                                //
                                return; 
                            }

                            //
                            //  Populate the grid with the values we got from the sproc.
                            //
                            while(rd.Read())
                            {
                                int rowIdx = grdSqlData.Rows.Add();
                                for( int col = 0 ; col < rd.FieldCount; col++) 
                                {
                                    grdSqlData.Rows[rowIdx].Cells[col].Value = GetReaderValue( rd[col] );                                   
                                }
                            }                            
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.Message, "Program Error..." );
            }
        }   

        //
        //  Get the query parameters for the stored procedure.
        //
        private List<SqlParameter> GetParamerForSproc( SqlConnection cn, string schemaName, string sprocName )
        {
            List<SqlParameter> paramcoll = new List<SqlParameter>();
            Dictionary<string,string> procParams = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            using(SqlConnection cnSqlParam = new SqlConnection( cn.ConnectionString ))
            {
                cnSqlParam.Open();
                DataTable spTable = cnSqlParam.GetSchema("ProcedureParameters",new[]{ "northwind",schemaName, sprocName});
                
                foreach(DataRow row in spTable.Rows)
                {
                    procParams.Add(row["PARAMETER_NAME"].ToString(),row["DATA_TYPE"].ToString());
                }

                if( procParams.Count() <1)
                {
                    return paramcoll;                    
                }

                MessageBox.Show( "Please enter a value for the  parameters for the sproce selected..." );

                foreach( var param in procParams)
                {
                    frmSqlParam sprocForm = new frmSqlParam(param.Key, param.Value);
                    sprocForm.ShowDialog();
                    var parameVal = sprocForm.txtParamValue.Text.Trim();  
                    paramcoll.Add(new SqlParameter( param.Key, parameVal  ));
                }

                return paramcoll; 
            }  
        }

        //
        //  Get the column value, may be null...
        //
        private string GetReaderValue( object sqlDataReaderColumn )
        {
            if( sqlDataReaderColumn == null || sqlDataReaderColumn == DBNull.Value) 
            {
                return "";
            }

            return (string) sqlDataReaderColumn.ToString();
        }

        //
        //  Init the datagrid showing the query results,  Will assume grid had rows from 
        //  previous execution.  So we alway init the grid and add the columns with the column
        //  header.
        //
        private void SetupGrid( SqlDataReader rd )
        {
            if(rd.HasRows)
            {
                grdSqlData.Rows.Clear();
                grdSqlData.Columns.Clear();

                for( int idx = 0 ; idx < rd.FieldCount; idx++)
                {
                    grdSqlData.Columns.Add(rd.GetName(idx),rd.GetName(idx));
                }
            }
        }

        //
        //  Exit program...
        //
        private void cmdExitProgram_Click( object sender, EventArgs e )
        {
            if(MessageBox.Show( "Exit program", "Exit progam?", MessageBoxButtons.YesNo ) == DialogResult.Yes )
            {
                this.Close();
            }
        }
    }
}
