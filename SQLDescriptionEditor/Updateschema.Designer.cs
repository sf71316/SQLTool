namespace SQLDescriptionEditor
{
    partial class Updateschema
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDbContext = new System.Windows.Forms.ComboBox();
            this.cbtemplate = new System.Windows.Forms.ComboBox();
            this.gpupdatemethod = new System.Windows.Forms.GroupBox();
            this.rbselect2 = new System.Windows.Forms.RadioButton();
            this.rbselect1 = new System.Windows.Forms.RadioButton();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cbIsoriginal = new System.Windows.Forms.CheckBox();
            this.gpupdatemethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Connection Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "DataBase";
            // 
            // cbDbContext
            // 
            this.cbDbContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDbContext.Enabled = false;
            this.cbDbContext.FormattingEnabled = true;
            this.cbDbContext.Location = new System.Drawing.Point(12, 71);
            this.cbDbContext.Name = "cbDbContext";
            this.cbDbContext.Size = new System.Drawing.Size(201, 20);
            this.cbDbContext.TabIndex = 7;
            // 
            // cbtemplate
            // 
            this.cbtemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtemplate.FormattingEnabled = true;
            this.cbtemplate.Location = new System.Drawing.Point(12, 22);
            this.cbtemplate.Name = "cbtemplate";
            this.cbtemplate.Size = new System.Drawing.Size(201, 20);
            this.cbtemplate.TabIndex = 6;
            this.cbtemplate.SelectionChangeCommitted += new System.EventHandler(this.cbtemplate_SelectionChangeCommitted);
            // 
            // gpupdatemethod
            // 
            this.gpupdatemethod.Controls.Add(this.rbselect2);
            this.gpupdatemethod.Controls.Add(this.rbselect1);
            this.gpupdatemethod.Location = new System.Drawing.Point(12, 98);
            this.gpupdatemethod.Name = "gpupdatemethod";
            this.gpupdatemethod.Size = new System.Drawing.Size(226, 70);
            this.gpupdatemethod.TabIndex = 10;
            this.gpupdatemethod.TabStop = false;
            this.gpupdatemethod.Text = "Update type ";
            // 
            // rbselect2
            // 
            this.rbselect2.AutoSize = true;
            this.rbselect2.Location = new System.Drawing.Point(7, 44);
            this.rbselect2.Name = "rbselect2";
            this.rbselect2.Size = new System.Drawing.Size(204, 16);
            this.rbselect2.TabIndex = 1;
            this.rbselect2.TabStop = true;
            this.rbselect2.Text = "All column schema without description";
            this.rbselect2.UseVisualStyleBackColor = true;
            this.rbselect2.Click += new System.EventHandler(this.Update_Type_Click);
            // 
            // rbselect1
            // 
            this.rbselect1.AutoSize = true;
            this.rbselect1.Location = new System.Drawing.Point(7, 22);
            this.rbselect1.Name = "rbselect1";
            this.rbselect1.Size = new System.Drawing.Size(112, 16);
            this.rbselect1.TabIndex = 0;
            this.rbselect1.TabStop = true;
            this.rbselect1.Text = "All column schema";
            this.rbselect1.UseVisualStyleBackColor = true;
            this.rbselect1.Click += new System.EventHandler(this.Update_Type_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnupdate.Enabled = false;
            this.btnupdate.Location = new System.Drawing.Point(197, 215);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cbIsoriginal
            // 
            this.cbIsoriginal.AutoSize = true;
            this.cbIsoriginal.Location = new System.Drawing.Point(12, 175);
            this.cbIsoriginal.Name = "cbIsoriginal";
            this.cbIsoriginal.Size = new System.Drawing.Size(104, 16);
            this.cbIsoriginal.TabIndex = 13;
            this.cbIsoriginal.Text = "Original database";
            this.cbIsoriginal.UseVisualStyleBackColor = true;
            this.cbIsoriginal.CheckedChanged += new System.EventHandler(this.cbIsoriginal_CheckedChanged);
            // 
            // Updateschema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 250);
            this.Controls.Add(this.cbIsoriginal);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.gpupdatemethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDbContext);
            this.Controls.Add(this.cbtemplate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Updateschema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update table schema from....";
            this.Load += new System.EventHandler(this.Updateschema_Load);
            this.gpupdatemethod.ResumeLayout(false);
            this.gpupdatemethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDbContext;
        private System.Windows.Forms.ComboBox cbtemplate;
        private System.Windows.Forms.GroupBox gpupdatemethod;
        private System.Windows.Forms.RadioButton rbselect1;
        private System.Windows.Forms.RadioButton rbselect2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.CheckBox cbIsoriginal;
    }
}