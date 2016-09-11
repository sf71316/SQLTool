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
    public partial class Updateschema : Form
    {
        TableEntity _table;
        ConnectionEntity _config;
        public Updateschema()
        {
            InitializeComponent();
        }
        public Updateschema(TableEntity table, ConnectionEntity config) : this()
        {
            _table = table;
            _config = config;
        }
        private void Updateschema_Load(object sender, EventArgs e)
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
                    var entity = ConfigureModel.Find(cbtemplate.SelectedValue.ToString());
                    DbContext db = new DbContext(entity);
                    cbDbContext.DataSource = db.GetDataBases();
                    cbDbContext.Enabled = true;
                }
                this.btnupdate.Enabled = this.CheckData();
            }
        }
        private bool CheckData()
        {
            return (cbIsoriginal.Checked ||( cbtemplate.SelectedIndex > -1 && cbDbContext.SelectedIndex > -1)) &&
                (rbselect1.Checked || rbselect2.Checked);
        }
        private void Update_Type_Click(object sender, EventArgs e)
        {
            this.btnupdate.Enabled = this.CheckData();
        }

        private async void btnupdate_Click(object sender, EventArgs e)
        {
            ProjectModel model = new ProjectModel();
            if (!cbIsoriginal.Checked)
            {
                _config = ConfigureModel.Find(cbtemplate.SelectedValue.ToString());
                _config.DbName = cbDbContext.SelectedValue.ToString();
            }
            model.Notify += Model_Notify;
            await Task.Run(() =>
            {
               this.Invoke(new Action(() => {
                   btnupdate.Enabled = false;
               }));
               model.UpdateSchema(_table, rbselect2.Checked, cbIsoriginal.Checked, _config, this.Invoke);
            });
            
           btnupdate.Enabled = true;
        }

        private void Model_Notify(object sender, NotifyArg e)
        {
            if (this.Notify != null)
                this.Notify(sender, e);
        }

        private void cbIsoriginal_CheckedChanged(object sender, EventArgs e)
        {
            cbDbContext.Enabled = !cbIsoriginal.Checked;
            cbtemplate.Enabled = !cbIsoriginal.Checked;
        }
        public event EventHandler<NotifyArg> Notify;
    }
}
