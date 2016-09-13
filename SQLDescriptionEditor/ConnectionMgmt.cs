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
    public partial class ConnectionMgmt : Form
    {
        List<ConnectionEntity> Connections;
        ConnectionEntity _currentEntity = null;
        public ConnectionMgmt()
        {
            InitializeComponent();
            cbtemplate.SelectedIndex = 0;
            Connections = ConfigureModel.GetDefaultConnectionList().ToList();
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
                    VaildData();
                }

            }
        }

        private void VaildData()
        {
            this.btnSave.Enabled = this.tbConnectionname.Text.Length > 0 && _currentEntity != null;
        }

        private void ConnectionMgmt_Load(object sender, EventArgs e)
        {
            var connectionList = ConfigureModel.GetDefaultConnectionList()
                .Select(p => p.ConnectionName).ToList();
            connectionList.Insert(0, "New....");
            cbtemplate.DataSource = connectionList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (_currentEntity != null)
            {
                ConfigureModel Model = new ConfigureModel();
                if (cbtemplate.SelectedIndex == -1)
                {
                    _currentEntity.ConnectionName = this.tbConnectionname.Text;
                    Connections.Add(_currentEntity);
                }
                Model.Save(Connections, Configure.DEFAULT_CONNECTION_CONFIG_NAME);
                ConfigureModel.ClearCache();
                this.Close();
            }
        }

        private void tbConnectionname_TextChanged(object sender, EventArgs e)
        {
            this.tbConnectionname.Enabled = tbConnectionname.Text.Length > 0;
        }

        private void cbtemplate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbtemplate.SelectedIndex == 0)
            {
                tbConnectionname.Text = string.Empty;
                lnklbDelete.Enabled = false;
                _currentEntity = null;
            }
            else
            {
                lnklbDelete.Enabled = true;
                var data = this.Connections.FirstOrDefault(p => p.ConnectionName == cbtemplate.SelectedValue.ToString());
                this.tbConnectionname.Enabled = false;
                this.tbConnectionname.Text = data.ConnectionName;
                _currentEntity = data;

            }
        }
    }
}
