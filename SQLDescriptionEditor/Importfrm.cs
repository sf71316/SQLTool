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
    public partial class Importfrm : Form
    {
        public Importfrm()
        {
            InitializeComponent();
        }
        public ProjectEntity Project { get; set; }
        private void btnsync_Click(object sender, EventArgs e)
        {
            if (rbaddtable.Checked)
            {
                ImportNewTable();
            }
            else
            {
                SyncExistsTable();
            }
        }

        private void ImportNewTable()
        {
            ProjectModel model = new ProjectModel();
            model.GetRemainTable(this.Project);
        }

        private async void SyncExistsTable()
        {
            if (this.Project != null)
            {
                btnsync.Enabled = false;
                await Task.Run(() =>
                {
                    ProjectModel model = new ProjectModel();
                    model.Notify += Model_Notify;
                    model.SyncExistsTable(Project, this.Invoke);
                });
                btnsync.Enabled = true;
            }
        }

        private void Model_Notify(object sender, NotifyArg e)
        {
            this.Invoke(new Action(() =>
            {
                lbnotification.Text = e.Message;
            }));

        }
    }
}
