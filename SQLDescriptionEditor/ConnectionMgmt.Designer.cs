namespace SQLDescriptionEditor
{
    partial class ConnectionMgmt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnklbDelete = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtemplate = new System.Windows.Forms.ComboBox();
            this.tbConnectionname = new System.Windows.Forms.TextBox();
            this.btnOpenConnDialog = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnklbDelete
            // 
            this.lnklbDelete.AutoSize = true;
            this.lnklbDelete.Enabled = false;
            this.lnklbDelete.Location = new System.Drawing.Point(225, 19);
            this.lnklbDelete.Name = "lnklbDelete";
            this.lnklbDelete.Size = new System.Drawing.Size(34, 12);
            this.lnklbDelete.TabIndex = 13;
            this.lnklbDelete.TabStop = true;
            this.lnklbDelete.Text = "Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Connection Name";
            // 
            // cbtemplate
            // 
            this.cbtemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtemplate.FormattingEnabled = true;
            this.cbtemplate.Items.AddRange(new object[] {
            "New..."});
            this.cbtemplate.Location = new System.Drawing.Point(12, 12);
            this.cbtemplate.Name = "cbtemplate";
            this.cbtemplate.Size = new System.Drawing.Size(201, 20);
            this.cbtemplate.TabIndex = 11;
            this.cbtemplate.SelectionChangeCommitted += new System.EventHandler(this.cbtemplate_SelectionChangeCommitted);
            // 
            // tbConnectionname
            // 
            this.tbConnectionname.Location = new System.Drawing.Point(14, 62);
            this.tbConnectionname.Name = "tbConnectionname";
            this.tbConnectionname.Size = new System.Drawing.Size(286, 22);
            this.tbConnectionname.TabIndex = 10;
            this.tbConnectionname.TextChanged += new System.EventHandler(this.tbConnectionname_TextChanged);
            // 
            // btnOpenConnDialog
            // 
            this.btnOpenConnDialog.Location = new System.Drawing.Point(14, 105);
            this.btnOpenConnDialog.Name = "btnOpenConnDialog";
            this.btnOpenConnDialog.Size = new System.Drawing.Size(87, 23);
            this.btnOpenConnDialog.TabIndex = 14;
            this.btnOpenConnDialog.Text = "Connection....";
            this.btnOpenConnDialog.UseVisualStyleBackColor = true;
            this.btnOpenConnDialog.Click += new System.EventHandler(this.btnOpenConnDialog_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(299, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ConnectionMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 296);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenConnDialog);
            this.Controls.Add(this.lnklbDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtemplate);
            this.Controls.Add(this.tbConnectionname);
            this.Name = "ConnectionMgmt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New connection";
            this.Load += new System.EventHandler(this.ConnectionMgmt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnklbDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtemplate;
        private System.Windows.Forms.TextBox tbConnectionname;
        private System.Windows.Forms.Button btnOpenConnDialog;
        private System.Windows.Forms.Button btnSave;
    }
}