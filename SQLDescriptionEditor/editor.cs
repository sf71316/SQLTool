using SQLDesctionEditor.Lib.Entity;
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
        BindingSource tableschemaContext;
        public editor()
        {
            InitializeComponent();
            this.dgvTableschema.AutoGenerateColumns = false;
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
        private void BindData(string OrderBy = "")
        {
            var table = Project.Tables
               .FirstOrDefault(p => p.Table_Name == lbTableList.SelectedValue.ToString());
            if (table != null)
            {
                tableschemaContext = new BindingSource();
                tableschemaContext.DataSource = table.Columns;
                if (!string.IsNullOrEmpty(OrderBy))
                    tableschemaContext.Sort = OrderBy;
                dgvTableschema.DataSource = tableschemaContext;
                tbtableName.DataBindings.Clear();
                tbtableName.DataBindings.Add("Text", table, "Table_Name");
                tbDescritpion.DataBindings.Clear();
                tbDescritpion.DataBindings.Add("Text", table, "Description", false, DataSourceUpdateMode.OnPropertyChanged);


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
            _config.DbName = Project.DbName;
            var updatefrm = new Updateschema(table, _config);
            updatefrm.ShowDialog();
            if (tableschemaContext != null)
            {
                int currentindex = this.lbTableList.SelectedIndex;
                tableschemaContext.ResetBindings(false);
                LoadTableList(tbKeyword.Text);
                this.lbTableList.SelectedIndex = currentindex;
            }
        }

        private void editor_Enter(object sender, EventArgs e)
        {
            if (this.Editing != null)
                this.Editing(this, new SubFormTransferArgs { Project = this.Project });
        }
        public event EventHandler<SubFormTransferArgs> Editing;
        public event EventHandler<EventArgs> Edited;

        private void editor_Leave(object sender, EventArgs e)
        {
            if (this.Edited != null)
                this.Edited(this, new EventArgs());
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
            //TextBox autoText = e.Control as TextBox;
            //if (autoText != null)
            //{
            //    autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //    AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            //    addItems(DataCollection);
            //    autoText.AutoCompleteCustomSource = DataCollection;
            //}
        }
        

    }
}
