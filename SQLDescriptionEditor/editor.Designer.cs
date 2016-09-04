namespace SQLDescriptionEditor
{
    partial class editor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.spcLeft = new System.Windows.Forms.SplitContainer();
            this.lbTableList = new System.Windows.Forms.ListBox();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcLeft)).BeginInit();
            this.spcLeft.Panel1.SuspendLayout();
            this.spcLeft.Panel2.SuspendLayout();
            this.spcLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.spcLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Size = new System.Drawing.Size(658, 391);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 0;
            // 
            // spcLeft
            // 
            this.spcLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcLeft.Location = new System.Drawing.Point(0, 0);
            this.spcLeft.Name = "spcLeft";
            this.spcLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcLeft.Panel1
            // 
            this.spcLeft.Panel1.Controls.Add(this.tbKeyword);
            // 
            // spcLeft.Panel2
            // 
            this.spcLeft.Panel2.Controls.Add(this.lbTableList);
            this.spcLeft.Size = new System.Drawing.Size(156, 391);
            this.spcLeft.SplitterDistance = 28;
            this.spcLeft.TabIndex = 0;
            // 
            // lbTableList
            // 
            this.lbTableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTableList.FormattingEnabled = true;
            this.lbTableList.ItemHeight = 12;
            this.lbTableList.Location = new System.Drawing.Point(0, 0);
            this.lbTableList.Name = "lbTableList";
            this.lbTableList.Size = new System.Drawing.Size(156, 359);
            this.lbTableList.TabIndex = 1;
            // 
            // tbKeyword
            // 
            this.tbKeyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbKeyword.Location = new System.Drawing.Point(0, 0);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(156, 22);
            this.tbKeyword.TabIndex = 0;
            this.tbKeyword.TextChanged += new System.EventHandler(this.tbKeyword_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 391);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " SQL Table Description Editor";
            this.Load += new System.EventHandler(this.editor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.spcLeft.Panel1.ResumeLayout(false);
            this.spcLeft.Panel1.PerformLayout();
            this.spcLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcLeft)).EndInit();
            this.spcLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer spcLeft;
        private System.Windows.Forms.ListBox lbTableList;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Button btnSave;
    }
}