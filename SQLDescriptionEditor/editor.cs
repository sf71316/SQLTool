﻿using SQLDesctionEditor.Lib.Entity;
using SQLDesctionEditor.Lib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDescriptionEditor
{
    public partial class editor : BaseForm
    {
        public ProjectEntity Project { get; private set; }
        AutoCompleteDataSource autosource;
        BindingSource tableschemaContext;
        public editor()
        {

            InitializeComponent();
            this.dgvTableschema.AutoGenerateColumns = false;
            this.SetDoubleBuffered(this.dgvTableschema);
            this.SetDoubleBuffered(this.lbTableList);
            this.lbTableList.DrawItem += LbTableList_DrawItem;
        }

        private void LbTableList_DrawItem(object sender, DrawItemEventArgs e)
        {
            var color = Color.White;
            var item = lbTableList.Items[e.Index] as TableEntity;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.Yellow);
            else  if (item.NeedUpdate)
            {
                color = Color.FromArgb(255,186,125);
            }
            e.DrawBackground();
            Graphics g = e.Graphics;

            g.FillRectangle(new SolidBrush(color), e.Bounds);

            // Print text
            e.Graphics.DrawString(item.Table_Name, e.Font, Brushes.Black,
                e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        public editor(ProjectEntity project) : this()
        {
            this.Project = project;
        }
        private void editor_Load(object sender, EventArgs e)
        {
            LoadTableList();
            this.ActiveControl = lbTableList;
            this.Text += "- " + Project.ProjectName;
            LoadAutoCompleteSource();
        }
        private void LoadAutoCompleteSource()
        {
            autosource = new AutoCompleteDataSource(this.Project.Tables);
            autosource.Generate();
        }
        private void LoadTableList(string keyword = "")
        {
            lbTableList.DisplayMember = "Table_Name";
            lbTableList.ValueMember = "Table_Name";
            lbTableList.DataSource = this.Project.Tables
                .Where(p => p.Table_Name.ToLower().Contains(keyword.ToLower())).ToList();
        }
        private void tbKeyword_TextChanged(object sender, EventArgs e)
        {
            LoadTableList(this.tbKeyword.Text);
        }
        private void lbTableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BindData();
        }
        private void BindData(string keyword = "", string OrderBy = "")
        {
            var table = Project.Tables
               .FirstOrDefault(p => p.Table_Name == lbTableList.SelectedValue.ToString());
            if (table != null)
            {
                tableschemaContext = new BindingSource();
                if (string.IsNullOrEmpty(keyword))
                    tableschemaContext.DataSource = table.Columns;
                else
                    tableschemaContext.DataSource = table.Columns.Where(p => p.Column.ToLower().Contains(keyword.ToLower())).ToList();
                if (!string.IsNullOrEmpty(OrderBy))
                    tableschemaContext.Sort = OrderBy;
                dgvTableschema.DataSource = tableschemaContext;
                tbtableName.DataBindings.Clear();
                tbtableName.DataBindings.Add("Text", table, "Table_Name");
                tbDescritpion.DataBindings.Clear();
                tbDescritpion.DataBindings.Add("Text", table, "Description", false,
                    DataSourceUpdateMode.OnPropertyChanged);


            }
        }
        private void dgvTableschema_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //this.BindData(dgvTableschema.Columns[e.ColumnIndex].DataPropertyName);
        }
        private void toolbtnupdate_Click(object sender, EventArgs e)
        {
            var table = Project.Tables
               .FirstOrDefault(p => p.Table_Name == lbTableList.SelectedValue.ToString());
            var _config = ConfigureModel.Find(Project.ConnectionName);
            var updatefrm = new Updateschema(table, _config);
            updatefrm.Notify += Updatefrm_Notify;
            updatefrm.ShowDialog();
            if (tableschemaContext != null)
            {
                int currentindex = this.lbTableList.SelectedIndex;
                tableschemaContext.ResetBindings(false);
                LoadTableList(tbKeyword.Text);
                this.lbTableList.SelectedIndex = currentindex;
            }
        }

        private void Updatefrm_Notify(object sender, NotifyArg e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    this.SendNotify(e.Message);
                }));
            }
            else
            {
                this.SendNotify(e.Message);
            }
        }

        private void toolStripRemoveTableButton_Click(object sender, EventArgs e)
        {
            var table = Project.Tables
             .FirstOrDefault(p => p.Table_Name == lbTableList.SelectedValue.ToString());
            if (MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!",
                                     MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var index = lbTableList.SelectedIndex;
                Project.Tables.Remove(table);
                LoadTableList();
                lbTableList.SelectedIndex = index;
            }
        }
        private void dgvTableschema_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox autoText = e.Control as TextBox;
            if (autoText != null)
            {
                autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                var columnName = this.dgvTableschema.CurrentRow.Cells[0].Value.ToString();
                DataCollection.AddRange(autosource.FindCompleteSource(columnName).ToArray());
                autoText.AutoCompleteCustomSource = DataCollection;
            }
        }
        private void tbCKeyword_TextChanged(object sender, EventArgs e)
        {
            this.BindData(keyword: tbCKeyword.Text);
        }
        public void RefreshData()
        {
            LoadTableList();
            BindData();
            this.SendNotify("Sync table complete.");
        }

        private void dgvTableschema_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var columnName = this.dgvTableschema.CurrentRow.Cells[0].Value.ToString();

        }
    }
}
