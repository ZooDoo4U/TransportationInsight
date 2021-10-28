
namespace SprocCallTestApp
{
    partial class frmSqlParam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdOk = new System.Windows.Forms.Button();
            this.txtParamValue = new System.Windows.Forms.TextBox();
            this.lblParamName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(251, 168);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(78, 30);
            this.cmdOk.TabIndex = 3;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // txtParamValue
            // 
            this.txtParamValue.Location = new System.Drawing.Point(57, 115);
            this.txtParamValue.Name = "txtParamValue";
            this.txtParamValue.Size = new System.Drawing.Size(460, 27);
            this.txtParamValue.TabIndex = 2;
            // 
            // lblParamName
            // 
            this.lblParamName.AutoSize = true;
            this.lblParamName.Location = new System.Drawing.Point(258, 71);
            this.lblParamName.Name = "lblParamName";
            this.lblParamName.Size = new System.Drawing.Size(58, 18);
            this.lblParamName.TabIndex = 1;
            this.lblParamName.Text = "label1";
            this.lblParamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter a value for";
            // 
            // frmSqlParam
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblParamName);
            this.Controls.Add(this.txtParamValue);
            this.Controls.Add(this.cmdOk);
            this.Name = "frmSqlParam";
            this.Text = "Enter a value for sproc param";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Label lblParamName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtParamValue;
    }
}