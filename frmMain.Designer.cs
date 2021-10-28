
namespace SprocCallTestApp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSprocName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSchema = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdFetchData = new System.Windows.Forms.Button();
            this.grdSqlData = new System.Windows.Forms.DataGridView();
            this.cmdExitProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdSqlData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Server";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(97, 9);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(274, 27);
            this.txtServerName.TabIndex = 1;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(585, 9);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(298, 27);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Database";
            // 
            // txtSprocName
            // 
            this.txtSprocName.Location = new System.Drawing.Point(585, 42);
            this.txtSprocName.Name = "txtSprocName";
            this.txtSprocName.Size = new System.Drawing.Size(298, 27);
            this.txtSprocName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Procedure Name";
            // 
            // txtSchema
            // 
            this.txtSchema.Location = new System.Drawing.Point(97, 42);
            this.txtSchema.Name = "txtSchema";
            this.txtSchema.Size = new System.Drawing.Size(274, 27);
            this.txtSchema.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sc&hema";
            // 
            // cmdFetchData
            // 
            this.cmdFetchData.Location = new System.Drawing.Point(915, 22);
            this.cmdFetchData.Name = "cmdFetchData";
            this.cmdFetchData.Size = new System.Drawing.Size(113, 41);
            this.cmdFetchData.TabIndex = 8;
            this.cmdFetchData.Text = "Fetch &Data";
            this.cmdFetchData.UseVisualStyleBackColor = true;
            this.cmdFetchData.Click += new System.EventHandler(this.cmdFetchData_Click);
            // 
            // grdSqlData
            // 
            this.grdSqlData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSqlData.Location = new System.Drawing.Point(13, 93);
            this.grdSqlData.Name = "grdSqlData";
            this.grdSqlData.RowTemplate.Height = 29;
            this.grdSqlData.Size = new System.Drawing.Size(1017, 360);
            this.grdSqlData.TabIndex = 9;
            // 
            // cmdExitProgram
            // 
            this.cmdExitProgram.Location = new System.Drawing.Point(871, 466);
            this.cmdExitProgram.Name = "cmdExitProgram";
            this.cmdExitProgram.Size = new System.Drawing.Size(159, 38);
            this.cmdExitProgram.TabIndex = 10;
            this.cmdExitProgram.Text = "E&xit Program";
            this.cmdExitProgram.UseVisualStyleBackColor = true;
            this.cmdExitProgram.Click += new System.EventHandler(this.cmdExitProgram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 516);
            this.Controls.Add(this.cmdExitProgram);
            this.Controls.Add(this.grdSqlData);
            this.Controls.Add(this.cmdFetchData);
            this.Controls.Add(this.txtSchema);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSprocName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";            
            ((System.ComponentModel.ISupportInitialize)(this.grdSqlData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSprocName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSchema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdFetchData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdExitProgram;
        private System.Windows.Forms.DataGridView grdSqlData;
    }
}

