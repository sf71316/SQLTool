namespace SQLDescriptionEditor
{
    partial class connectmgmt
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbtemplate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAuthmode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbservername = new System.Windows.Forms.TextBox();
            this.plauth = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpwd = new System.Windows.Forms.TextBox();
            this.btntest = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.plauth.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 22);
            this.textBox1.TabIndex = 0;
            // 
            // cbtemplate
            // 
            this.cbtemplate.FormattingEnabled = true;
            this.cbtemplate.Items.AddRange(new object[] {
            "New..."});
            this.cbtemplate.Location = new System.Drawing.Point(13, 13);
            this.cbtemplate.Name = "cbtemplate";
            this.cbtemplate.Size = new System.Drawing.Size(201, 20);
            this.cbtemplate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.plauth);
            this.groupBox1.Controls.Add(this.cbAuthmode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 138);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log on to the server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Authentication";
            // 
            // cbAuthmode
            // 
            this.cbAuthmode.FormattingEnabled = true;
            this.cbAuthmode.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cbAuthmode.Location = new System.Drawing.Point(88, 17);
            this.cbAuthmode.Name = "cbAuthmode";
            this.cbAuthmode.Size = new System.Drawing.Size(199, 20);
            this.cbAuthmode.TabIndex = 1;
            this.cbAuthmode.SelectedIndexChanged += new System.EventHandler(this.cbAuthmode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server Name";
            // 
            // tbservername
            // 
            this.tbservername.Location = new System.Drawing.Point(15, 110);
            this.tbservername.Name = "tbservername";
            this.tbservername.Size = new System.Drawing.Size(286, 22);
            this.tbservername.TabIndex = 4;
            // 
            // plauth
            // 
            this.plauth.Controls.Add(this.tbpwd);
            this.plauth.Controls.Add(this.tbusername);
            this.plauth.Controls.Add(this.label5);
            this.plauth.Controls.Add(this.label4);
            this.plauth.Enabled = false;
            this.plauth.Location = new System.Drawing.Point(27, 43);
            this.plauth.Name = "plauth";
            this.plauth.Size = new System.Drawing.Size(358, 72);
            this.plauth.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "User name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password:";
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(61, 4);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(282, 22);
            this.tbusername.TabIndex = 6;
            // 
            // tbpwd
            // 
            this.tbpwd.Location = new System.Drawing.Point(61, 41);
            this.tbpwd.Name = "tbpwd";
            this.tbpwd.PasswordChar = '*';
            this.tbpwd.Size = new System.Drawing.Size(282, 22);
            this.tbpwd.TabIndex = 7;
            this.tbpwd.UseSystemPasswordChar = true;
            // 
            // btntest
            // 
            this.btntest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btntest.Location = new System.Drawing.Point(13, 306);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(106, 23);
            this.btntest.TabIndex = 6;
            this.btntest.Text = "Test Connection";
            this.btntest.UseVisualStyleBackColor = true;
            this.btntest.Click += new System.EventHandler(this.btntest_Click);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.Location = new System.Drawing.Point(226, 306);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "OK";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Location = new System.Drawing.Point(325, 306);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // connectmgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 349);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbservername);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtemplate);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "connectmgmt";
            this.Text = "DB Connection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.plauth.ResumeLayout(false);
            this.plauth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbtemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAuthmode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbservername;
        private System.Windows.Forms.Panel plauth;
        private System.Windows.Forms.TextBox tbpwd;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
    }
}