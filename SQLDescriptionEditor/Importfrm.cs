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
    public partial class Importfrm : BaseForm
    {
        public Importfrm()
        {
            InitializeComponent();
            this.Height = 189;
        }
        public ProjectEntity Project { get; set; }
        private  void btnsync_Click(object sender, EventArgs e)
        {
            if (btnsync.Text == "Sync")
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
            else
            {
                var tables = lbAddTable.SelectedItems.Cast<TableEntity>();
                foreach (var item in tables)
                {
                    Project.Tables.Add(item);
                }
                Project.Tables = Project.Tables.OrderBy(p => p.Table_Name).ToList();
                this.Close();
            }
        }

        private void ImportNewTable()
        {
           
            ProjectModel model = new ProjectModel();
            var tables = model.GetRemainTable(this.Project);
            if (tables != null)
            {
                this.Height = 378;
                this.lbAddTable.Visible = true;
                btnsync.Text = "Confirm";
                lbAddTable.DataSource = tables;
                lbAddTable.DisplayMember = "Table_Name";
                lbAddTable.ValueMember = "Table_Name";
            }else
            {
                MessageBox.Show("not find table to add.","");
            }

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
                this.Close();
            }
        }

        private void Model_Notify(object sender, NotifyArg e)
        {
            if (this.Notify != null)
                this.Notify(sender, e);
        }
        public event EventHandler<NotifyArg> Notify;
    }
}
