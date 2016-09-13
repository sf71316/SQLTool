namespace SQLDescriptionEditor
{
    partial class newprojfrm
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
            this.btncreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbprojname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenConnDialog = new System.Windows.Forms.Button();
            this.cbNewConn = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbtemplate = new System.Windows.Forms.ComboBox();
            this.tbConnectInfo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncreate
            // 
            this.btncreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btncreate.Enabled = false;
            this.btncreate.Location = new System.Drawing.Point(263, 205);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(75, 23);
            this.btncreate.TabIndex = 6;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Project Name";
            // 
            // tbprojname
            // 
            this.tbprojname.Location = new System.Drawing.Point(15, 205);
            this.tbprojname.Name = "tbprojname";
            this.tbprojname.Size = new System.Drawing.Size(201, 22);
            this.tbprojname.TabIndex = 8;
            this.tbprojname.TextChanged += new System.EventHandler(this.tbprojname_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenConnDialog);
            this.groupBox1.Controls.Add(this.cbNewConn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbtemplate);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 130);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Connection";
            // 
            // btnOpenConnDialog
            // 
            this.btnOpenConnDialog.Enabled = false;
            this.btnOpenConnDialog.Location = new System.Drawing.Point(8, 93);
            this.btnOpenConnDialog.Name = "btnOpenConnDialog";
            this.btnOpenConnDialog.Size = new System.Drawing.Size(87, 23);
            this.btnOpenConnDialog.TabIndex = 15;
            this.btnOpenConnDialog.Text = "Connection....";
            this.btnOpenConnDialog.UseVisualStyleBackColor = true;
            this.btnOpenConnDialog.Click += new System.EventHandler(this.btnOpenConnDialog_Click);
            // 
            // cbNewConn
            // 
            this.cbNewConn.AutoSize = true;
            this.cbNewConn.Location = new System.Drawing.Point(8, 71);
            this.cbNewConn.Name = "cbNewConn";
            this.cbNewConn.Size = new System.Drawing.Size(102, 16);
            this.cbNewConn.TabIndex = 8;
            this.cbNewConn.Text = "New Connection";
            this.cbNewConn.UseVisualStyleBackColor = true;
            this.cbNewConn.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Connection Name";
            // 
            // cbtemplate
            // 
            this.cbtemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtemplate.FormattingEnabled = true;
            this.cbtemplate.Location = new System.Drawing.Point(8, 38);
            this.cbtemplate.Name = "cbtemplate";
            this.cbtemplate.Size = new System.Drawing.Size(201, 20);
            this.cbtemplate.TabIndex = 6;
            this.cbtemplate.SelectionChangeCommitted += new System.EventHandler(this.cbtemplate_SelectionChangeCommitted);
            // 
            // tbConnectInfo
            // 
            this.tbConnectInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConnectInfo.Location = new System.Drawing.Point(15, 155);
            this.tbConnectInfo.Name = "tbConnectInfo";
            this.tbConnectInfo.Size = new System.Drawing.Size(324, 15);
            this.tbConnectInfo.TabIndex = 10;
            // 
            // newprojfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 240);
            this.Controls.Add(this.tbConnectInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbprojname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newprojfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Project";
            this.Load += new System.EventHandler(this.newprojfrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbprojname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbNewConn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbtemplate;
        private System.Windows.Forms.Button btnOpenConnDialog;
        private System.Windows.Forms.TextBox tbConnectInfo;
    }
}