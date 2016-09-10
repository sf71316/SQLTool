namespace SQLDescriptionEditor
{
    partial class Importfrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbsync = new System.Windows.Forms.RadioButton();
            this.rbaddtable = new System.Windows.Forms.RadioButton();
            this.btnsync = new System.Windows.Forms.Button();
            this.lbnotification = new System.Windows.Forms.Label();
            this.lbAddTable = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbsync);
            this.groupBox1.Controls.Add(this.rbaddtable);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sync type";
            // 
            // rbsync
            // 
            this.rbsync.AutoSize = true;
            this.rbsync.Location = new System.Drawing.Point(7, 44);
            this.rbsync.Name = "rbsync";
            this.rbsync.Size = new System.Drawing.Size(103, 16);
            this.rbsync.TabIndex = 1;
            this.rbsync.TabStop = true;
            this.rbsync.Text = "Sync exists tables";
            this.rbsync.UseVisualStyleBackColor = true;
            // 
            // rbaddtable
            // 
            this.rbaddtable.AutoSize = true;
            this.rbaddtable.Location = new System.Drawing.Point(7, 22);
            this.rbaddtable.Name = "rbaddtable";
            this.rbaddtable.Size = new System.Drawing.Size(90, 16);
            this.rbaddtable.TabIndex = 0;
            this.rbaddtable.TabStop = true;
            this.rbaddtable.Text = "Add new table";
            this.rbaddtable.UseVisualStyleBackColor = true;
            // 
            // btnsync
            // 
            this.btnsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsync.Location = new System.Drawing.Point(197, 304);
            this.btnsync.Name = "btnsync";
            this.btnsync.Size = new System.Drawing.Size(75, 23);
            this.btnsync.TabIndex = 1;
            this.btnsync.Text = "Sync";
            this.btnsync.UseVisualStyleBackColor = true;
            this.btnsync.Click += new System.EventHandler(this.btnsync_Click);
            // 
            // lbnotification
            // 
            this.lbnotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbnotification.AutoSize = true;
            this.lbnotification.Location = new System.Drawing.Point(20, 312);
            this.lbnotification.Name = "lbnotification";
            this.lbnotification.Size = new System.Drawing.Size(0, 12);
            this.lbnotification.TabIndex = 2;
            // 
            // lbAddTable
            // 
            this.lbAddTable.FormattingEnabled = true;
            this.lbAddTable.ItemHeight = 12;
            this.lbAddTable.Location = new System.Drawing.Point(13, 112);
            this.lbAddTable.Name = "lbAddTable";
            this.lbAddTable.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbAddTable.Size = new System.Drawing.Size(184, 172);
            this.lbAddTable.TabIndex = 3;
            this.lbAddTable.Visible = false;
            // 
            // Importfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 339);
            this.Controls.Add(this.lbAddTable);
            this.Controls.Add(this.lbnotification);
            this.Controls.Add(this.btnsync);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Importfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sync tables";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbaddtable;
        private System.Windows.Forms.RadioButton rbsync;
        private System.Windows.Forms.Button btnsync;
        private System.Windows.Forms.Label lbnotification;
        private System.Windows.Forms.ListBox lbAddTable;
    }
}