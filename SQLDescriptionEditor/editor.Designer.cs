using SQLDesctionEditor.Lib.Controls;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editor));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.spcLeft = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.lbTableList = new System.Windows.Forms.ListBox();
            this.tbCKeyword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolbtnupdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripRemoveTableButton = new System.Windows.Forms.ToolStripButton();
            this.tbtableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescritpion = new System.Windows.Forms.TextBox();
            this.dgvTableschema = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISNULLABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcLeft)).BeginInit();
            this.spcLeft.Panel1.SuspendLayout();
            this.spcLeft.Panel2.SuspendLayout();
            this.spcLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableschema)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.tbCKeyword);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.tbtableName);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tbDescritpion);
            this.splitContainer1.Panel2.Controls.Add(this.dgvTableschema);
            this.splitContainer1.Size = new System.Drawing.Size(951, 611);
            this.splitContainer1.SplitterDistance = 224;
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
            this.spcLeft.Panel1.Controls.Add(this.pictureBox1);
            this.spcLeft.Panel1.Controls.Add(this.tbKeyword);
            // 
            // spcLeft.Panel2
            // 
            this.spcLeft.Panel2.Controls.Add(this.lbTableList);
            this.spcLeft.Size = new System.Drawing.Size(224, 611);
            this.spcLeft.SplitterDistance = 40;
            this.spcLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tbKeyword
            // 
            this.tbKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKeyword.Location = new System.Drawing.Point(30, 9);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(185, 22);
            this.tbKeyword.TabIndex = 1;
            this.tbKeyword.TextChanged += new System.EventHandler(this.tbKeyword_TextChanged);
            // 
            // lbTableList
            // 
            this.lbTableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTableList.FormattingEnabled = true;
            this.lbTableList.ItemHeight = 12;
            this.lbTableList.Location = new System.Drawing.Point(0, 0);
            this.lbTableList.Name = "lbTableList";
            this.lbTableList.Size = new System.Drawing.Size(224, 567);
            this.lbTableList.TabIndex = 1;
            this.lbTableList.SelectedIndexChanged += new System.EventHandler(this.lbTableList_SelectedIndexChanged);
            // 
            // tbCKeyword
            // 
            this.tbCKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCKeyword.Location = new System.Drawing.Point(537, 64);
            this.tbCKeyword.Name = "tbCKeyword";
            this.tbCKeyword.Size = new System.Drawing.Size(183, 22);
            this.tbCKeyword.TabIndex = 9;
            this.tbCKeyword.TextChanged += new System.EventHandler(this.tbCKeyword_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(515, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnupdate,
            this.toolStripRemoveTableButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(723, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolbtnupdate
            // 
            this.toolbtnupdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnupdate.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnupdate.Image")));
            this.toolbtnupdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnupdate.Name = "toolbtnupdate";
            this.toolbtnupdate.Size = new System.Drawing.Size(23, 22);
            this.toolbtnupdate.ToolTipText = "Update table schema";
            this.toolbtnupdate.Click += new System.EventHandler(this.toolbtnupdate_Click);
            // 
            // toolStripRemoveTableButton
            // 
            this.toolStripRemoveTableButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRemoveTableButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRemoveTableButton.Image")));
            this.toolStripRemoveTableButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRemoveTableButton.Name = "toolStripRemoveTableButton";
            this.toolStripRemoveTableButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripRemoveTableButton.ToolTipText = "Remove this table schema";
            this.toolStripRemoveTableButton.Click += new System.EventHandler(this.toolStripRemoveTableButton_Click);
            // 
            // tbtableName
            // 
            this.tbtableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbtableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbtableName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbtableName.Location = new System.Drawing.Point(17, 30);
            this.tbtableName.MinimumSize = new System.Drawing.Size(0, 25);
            this.tbtableName.Name = "tbtableName";
            this.tbtableName.ReadOnly = true;
            this.tbtableName.Size = new System.Drawing.Size(324, 19);
            this.tbtableName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description:";
            // 
            // tbDescritpion
            // 
            this.tbDescritpion.Location = new System.Drawing.Point(83, 64);
            this.tbDescritpion.Name = "tbDescritpion";
            this.tbDescritpion.Size = new System.Drawing.Size(352, 22);
            this.tbDescritpion.TabIndex = 3;
            // 
            // dgvTableschema
            // 
            this.dgvTableschema.AllowUserToAddRows = false;
            this.dgvTableschema.AllowUserToDeleteRows = false;
            this.dgvTableschema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTableschema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableschema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.DataType,
            this.Length,
            this.ISNULLABLE,
            this.ColumnDefault,
            this.Description});
            this.dgvTableschema.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTableschema.Location = new System.Drawing.Point(2, 92);
            this.dgvTableschema.Name = "dgvTableschema";
            this.dgvTableschema.RowTemplate.Height = 24;
            this.dgvTableschema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTableschema.Size = new System.Drawing.Size(721, 516);
            this.dgvTableschema.TabIndex = 1;
            this.dgvTableschema.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvTableschema_EditingControlShowing);
            // 
            // Column
            // 
            this.Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column.DataPropertyName = "Column";
            this.Column.HeaderText = "Column Name";
            this.Column.MinimumWidth = 100;
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            // 
            // DataType
            // 
            this.DataType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DataType.DataPropertyName = "DataType";
            this.DataType.HeaderText = "Data Type";
            this.DataType.MinimumWidth = 100;
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Length.DataPropertyName = "Length";
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            this.Length.Width = 63;
            // 
            // ISNULLABLE
            // 
            this.ISNULLABLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ISNULLABLE.DataPropertyName = "ISNULLABLE";
            this.ISNULLABLE.HeaderText = "Null";
            this.ISNULLABLE.Name = "ISNULLABLE";
            this.ISNULLABLE.ReadOnly = true;
            this.ISNULLABLE.Width = 50;
            // 
            // ColumnDefault
            // 
            this.ColumnDefault.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnDefault.DataPropertyName = "ColumnDefault";
            this.ColumnDefault.HeaderText = "Default";
            this.ColumnDefault.Name = "ColumnDefault";
            this.ColumnDefault.ReadOnly = true;
            this.ColumnDefault.Width = 64;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MaxInputLength = 1000;
            this.Description.MinimumWidth = 100;
            this.Description.Name = "Description";
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 611);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table  Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.editor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.spcLeft.Panel1.ResumeLayout(false);
            this.spcLeft.Panel1.PerformLayout();
            this.spcLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcLeft)).EndInit();
            this.spcLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableschema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer spcLeft;
        private System.Windows.Forms.ListBox lbTableList;
        private System.Windows.Forms.DataGridView dgvTableschema;
        private System.Windows.Forms.TextBox tbDescritpion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.TextBox tbtableName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISNULLABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolbtnupdate;
        private System.Windows.Forms.ToolStripButton toolStripRemoveTableButton;
        private System.Windows.Forms.TextBox tbCKeyword;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}