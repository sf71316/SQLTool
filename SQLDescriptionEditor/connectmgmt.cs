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
    public partial class connectmgmt : Form
    {
        List<ConnectionEntity> Connections;

        public connectmgmt()
        {
            InitializeComponent();
            cbtemplate.SelectedIndex = 0;
            Connections = ConfigureModel.GetDefaultConnectionList().ToList();
        }

        private void cbAuthmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuthmode.SelectedIndex == 1)
            {
                this.plauth.Enabled = true;
            }
            else
            {
                this.plauth.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("This connection unavailable.", "Warning");
            }
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                MessageBox.Show("Test connection succeeded.", "Information");
            }
            else
            {
                MessageBox.Show("Test connection failure.", "Information");
            }
        }

        private void connectmgmt_Load(object sender, EventArgs e)
        {
            LoadConnectionDropdownList();
        }

        private void LoadConnectionDropdownList()
        {
            var connectionList = ConfigureModel.GetDefaultConnectionList().Select(p => p.ConnectionName).ToList();
            connectionList.Insert(0, "New....");
            cbtemplate.DataSource = connectionList;

        }
        private bool CheckData()
        {
            var _servername = this.tbservername.Text;
            var _iswinauth = cbAuthmode.SelectedIndex;
            var _userid = this.tbusername.Text;
            var _pwd = this.tbpwd.Text;
            var connstring = DbContext.GetConnectionString(_servername,
                 _iswinauth == 0, _userid, _pwd);
            var result = DbContext.TestConnect(connstring).Result;
            return result;

        }
        private void Save()
        {
            ConfigureModel Model = new ConfigureModel();

            if (cbtemplate.SelectedIndex == 0)//add
            {
                if (Connections.All(p => p.ConnectionName != this.tbConnectionname.Text))
                {
                    var newData = new ConnectionEntity();
                    newData.ConnectionName = this.tbConnectionname.Text;
                    newData.ServerName = this.tbservername.Text;
                    newData.WindowsAuthentication = cbAuthmode.SelectedIndex == 0;
                    newData.UserId = tbusername.Text;
                    newData.Password = tbpwd.Text;
                    Connections.Add(newData);
                    Model.Save(Connections, Configure.DEFAULT_CONNECTION_CONFIG_NAME);
                    ConfigureModel.ClearCache();
                }
                else
                {
                    MessageBox.Show("This connection name has exists.", "Warning");
                }

            }
            else //edit
            {
                var data = Connections.FirstOrDefault(p => p.ConnectionName == cbtemplate.SelectedValue.ToString());
                if (data != null)
                {
                    data.ConnectionName = this.tbConnectionname.Text;
                    data.ServerName = this.tbservername.Text;
                    data.WindowsAuthentication = cbAuthmode.SelectedIndex == 0;
                    data.UserId = tbusername.Text;
                    data.Password = tbpwd.Text;
                    Model.Save(Connections, Configure.DEFAULT_CONNECTION_CONFIG_NAME);
                }
                else
                {
                    MessageBox.Show("oops! ", "Warning");
                }
            }
        }
        private void tbusername_TextChanged(object sender, EventArgs e)
        {
            this.btnsave.Enabled = tbusername.Text.Length > 0 && tbpwd.Text.Length > 0;
        }

        private void tbpwd_TextChanged(object sender, EventArgs e)
        {
            this.btnsave.Enabled = tbusername.Text.Length > 0 && tbpwd.Text.Length > 0;
        }

        private void lnklbDelete_Click(object sender, EventArgs e)
        {

        }

        private void cbtemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtemplate.SelectedIndex == 0)
            {
                tbpwd.Text = tbusername.Text = tbservername.Text =
                    tbConnectionname.Text = string.Empty;
                cbAuthmode.SelectedIndex = -1;
                lnklbDelete.Enabled = false;
            }
            else
            {
                lnklbDelete.Enabled = true;
                var data = this.Connections.FirstOrDefault(p => p.ConnectionName == cbtemplate.SelectedValue.ToString());
                this.tbConnectionname.Enabled = false;
                this.tbConnectionname.Text = data.ConnectionName;
                this.tbservername.Text = data.ServerName;
                if (data.WindowsAuthentication)
                {
                    cbAuthmode.SelectedIndex = 0;
                }
                else
                {
                    cbAuthmode.SelectedIndex = 1;
                    tbusername.Text = data.UserId;
                    tbpwd.Text = data.Password;
                }

            }
        }
    }
}
