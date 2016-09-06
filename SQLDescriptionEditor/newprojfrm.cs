using SQLDesctionEditor.Lib;
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
    public partial class newprojfrm : Form
    {
        string _savepath;
        public ProjectEntity Project { get; protected set; }
        public newprojfrm(string SavePath) : this()
        {
            _savepath = SavePath;
        }
        public newprojfrm()
        {
            InitializeComponent();

        }

        private void newprojfrm_Load(object sender, EventArgs e)
        {
            LoadConnectionDropdownList();
        }
        private void LoadConnectionDropdownList()
        {
            var connectionList = ConfigureModel.GetDefaultConnectionList()
                .Select(p => p.ConnectionName).ToList();
            cbtemplate.DataSource = connectionList;
            cbtemplate.SelectedIndex = -1;
        }

        private void cbtemplate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbtemplate.SelectedIndex > -1)
            {
                if (!string.IsNullOrEmpty(cbtemplate.SelectedValue.ToString()))
                {
                    var entity = ConfigureModel.GetDefaultConnectionList()
                        .FirstOrDefault(p => p.ConnectionName == cbtemplate.SelectedValue.ToString());

                    DbContext db = new DbContext(entity);
                    cbDbContext.DataSource = db.GetDataBases();
                    cbDbContext.Enabled = true;
                }
            }
        }
        private bool CheckData()
        {
            return tbprojname.Text.Length > 3 && cbDbContext.SelectedIndex > -1;
        }


        private void tbprojname_TextChanged(object sender, EventArgs e)
        {
            this.btncreate.Enabled = CheckData();
        }

        private void cbDbContext_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.btncreate.Enabled = CheckData();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            ProjectModel model = new ProjectModel();
            this.Project = model.Create(cbtemplate.SelectedValue.ToString()
                , cbDbContext.SelectedValue.ToString());
            this.Project.ProjectName = tbprojname.Text;
            this.Close();
        }
    }
}
