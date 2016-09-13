using Microsoft.Data.ConnectionUI;
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
        ConnectionEntity _currentEntity = null;
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
        private bool CheckData()
        {
            return tbprojname.Text.Length > 3  &&
                _currentEntity!=null;
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
            this.Project = model.Create(_currentEntity);
            this.Project.ProjectName = tbprojname.Text;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.cbtemplate.Enabled = !cbNewConn.Checked;
            this.btnOpenConnDialog.Enabled = cbNewConn.Checked;
            if (cbNewConn.Checked)
            {
                _currentEntity = null;
                tbConnectInfo.Text = "";
            }else
            {
                selectdConnection();
            }
        }

        private void btnOpenConnDialog_Click(object sender, EventArgs e)
        {
            using (var dialog = new DataConnectionDialog())
            {
                DataSource.AddStandardDataSources(dialog);
                dialog.DataSources.Clear();
                dialog.DataSources.Add(DataSource.SqlDataSource);

                DialogResult userChoice = DataConnectionDialog.Show(dialog);

                if (userChoice == DialogResult.OK)
                {
                    if (_currentEntity == null)
                    {
                        _currentEntity = new ConnectionEntity();
                    }
                    _currentEntity.ConnectionString = dialog.ConnectionString;
                    _currentEntity.ProviderName = dialog.SelectedDataProvider.Name;
                    tbConnectInfo.Text = dialog.ConnectionString;
                    CheckData();
                }

            }
        }
        private void cbtemplate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectdConnection();
        }

        private void selectdConnection()
        {
            if (this.cbtemplate.SelectedIndex > -1)
            {
                _currentEntity = ConfigureModel.Find(cbtemplate.SelectedValue.ToString());
                tbConnectInfo.Text = _currentEntity.ConnectionString;
            }
        }
    }
}
