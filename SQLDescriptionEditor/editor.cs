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
    public partial class editor : Form
    {
        private ProjectEntity _project;

        public editor()
        {
            InitializeComponent();
        }
        public editor(ProjectEntity project) : this()
        {
            this._project = project;
        }

        private void editor_Load(object sender, EventArgs e)
        {
            LoadTableList();
        }

        private void LoadTableList(string keyword = "")
        {
            lbTableList.DisplayMember = "Table_Name";
            lbTableList.ValueMember = "Table_Name";
            lbTableList.DataSource = this._project.Tables
                .Where(p => p.Table_Name.ToLower().Contains(keyword.ToLower())).ToList();
        }

        private void tbKeyword_TextChanged(object sender, EventArgs e)
        {
            LoadTableList(this.tbKeyword.Text);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            ProjectModel model = new ProjectModel();
            if(await model.SaveAsync(_project))
            {
                MessageBox.Show("Save succeeded.");
            }else
            {
                MessageBox.Show("Save failure.");
            }
        }
    }
}
