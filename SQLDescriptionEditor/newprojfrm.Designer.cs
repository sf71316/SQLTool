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
            this.cbtemplate = new System.Windows.Forms.ComboBox();
            this.cbDbContext = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbprojname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbtemplate
            // 
            this.cbtemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtemplate.FormattingEnabled = true;
            this.cbtemplate.Location = new System.Drawing.Point(12, 28);
            this.cbtemplate.Name = "cbtemplate";
            this.cbtemplate.Size = new System.Drawing.Size(201, 20);
            this.cbtemplate.TabIndex = 2;
            this.cbtemplate.SelectionChangeCommitted += new System.EventHandler(this.cbtemplate_SelectionChangeCommitted);
            // 
            // cbDbContext
            // 
            this.cbDbContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDbContext.Enabled = false;
            this.cbDbContext.FormattingEnabled = true;
            this.cbDbContext.Location = new System.Drawing.Point(12, 77);
            this.cbDbContext.Name = "cbDbContext";
            this.cbDbContext.Size = new System.Drawing.Size(201, 20);
            this.cbDbContext.TabIndex = 3;
            this.cbDbContext.SelectionChangeCommitted += new System.EventHandler(this.cbDbContext_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "DataBase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Connection Name";
            // 
            // btncreate
            // 
            this.btncreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btncreate.Enabled = false;
            this.btncreate.Location = new System.Drawing.Point(263, 131);
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
            this.label3.Location = new System.Drawing.Point(13, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Project Name";
            // 
            // tbprojname
            // 
            this.tbprojname.Location = new System.Drawing.Point(12, 128);
            this.tbprojname.Name = "tbprojname";
            this.tbprojname.Size = new System.Drawing.Size(201, 22);
            this.tbprojname.TabIndex = 8;
            this.tbprojname.TextChanged += new System.EventHandler(this.tbprojname_TextChanged);
            // 
            // newprojfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 166);
            this.Controls.Add(this.tbprojname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDbContext);
            this.Controls.Add(this.cbtemplate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newprojfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Project";
            this.Load += new System.EventHandler(this.newprojfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbtemplate;
        private System.Windows.Forms.ComboBox cbDbContext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbprojname;
    }
}