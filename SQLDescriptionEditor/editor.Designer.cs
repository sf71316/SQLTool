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
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.lbTableList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescritpion = new System.Windows.Forms.TextBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.dgvTableschema = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISNULLABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbdelete = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcLeft)).BeginInit();
            this.spcLeft.Panel1.SuspendLayout();
            this.spcLeft.Panel2.SuspendLayout();
            this.spcLeft.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.lbdelete);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tbDescritpion);
            this.splitContainer1.Panel2.Controls.Add(this.lblTableName);
            this.splitContainer1.Panel2.Controls.Add(this.dgvTableschema);
            this.splitContainer1.Size = new System.Drawing.Size(859, 611);
            this.splitContainer1.SplitterDistance = 203;
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
            this.spcLeft.Size = new System.Drawing.Size(203, 611);
            this.spcLeft.SplitterDistance = 28;
            this.spcLeft.TabIndex = 0;
            // 
            // tbKeyword
            // 
            this.tbKeyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbKeyword.Location = new System.Drawing.Point(0, 0);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(203, 22);
            this.tbKeyword.TabIndex = 0;
            this.tbKeyword.TextChanged += new System.EventHandler(this.tbKeyword_TextChanged);
            // 
            // lbTableList
            // 
            this.lbTableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTableList.FormattingEnabled = true;
            this.lbTableList.ItemHeight = 12;
            this.lbTableList.Location = new System.Drawing.Point(0, 0);
            this.lbTableList.Name = "lbTableList";
            this.lbTableList.Size = new System.Drawing.Size(203, 579);
            this.lbTableList.TabIndex = 1;
            this.lbTableList.SelectedIndexChanged += new System.EventHandler(this.lbTableList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description:";
            // 
            // tbDescritpion
            // 
            this.tbDescritpion.Location = new System.Drawing.Point(83, 41);
            this.tbDescritpion.Name = "tbDescritpion";
            this.tbDescritpion.Size = new System.Drawing.Size(352, 22);
            this.tbDescritpion.TabIndex = 3;
            // 
            // lblTableName
            // 
            this.lblTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTableName.Location = new System.Drawing.Point(14, 16);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(0, 18);
            this.lblTableName.TabIndex = 2;
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
            this.dgvTableschema.Location = new System.Drawing.Point(2, 69);
            this.dgvTableschema.MultiSelect = false;
            this.dgvTableschema.Name = "dgvTableschema";
            this.dgvTableschema.RowTemplate.Height = 24;
            this.dgvTableschema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableschema.Size = new System.Drawing.Size(650, 539);
            this.dgvTableschema.TabIndex = 1;
            // 
            // Column
            // 
            this.Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column.DataPropertyName = "Column";
            this.Column.Frozen = true;
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
            this.Description.MinimumWidth = 100;
            this.Description.Name = "Description";
            // 
            // lbdelete
            // 
            this.lbdelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbdelete.AutoSize = true;
            this.lbdelete.Location = new System.Drawing.Point(451, 47);
            this.lbdelete.Name = "lbdelete";
            this.lbdelete.Size = new System.Drawing.Size(63, 12);
            this.lbdelete.TabIndex = 5;
            this.lbdelete.TabStop = true;
            this.lbdelete.Text = "Delete Table";
            this.lbdelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbdelete_LinkClicked);
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 611);
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
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.spcLeft.Panel1.ResumeLayout(false);
            this.spcLeft.Panel1.PerformLayout();
            this.spcLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcLeft)).EndInit();
            this.spcLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableschema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer spcLeft;
        private System.Windows.Forms.ListBox lbTableList;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.DataGridView dgvTableschema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISNULLABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.TextBox tbDescritpion;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbdelete;
    }
}