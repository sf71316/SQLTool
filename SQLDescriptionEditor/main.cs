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
using System.Windows.Input;

namespace SQLDescriptionEditor
{
    public partial class main : BaseForm
    {
        public main()
        {
            InitializeComponent();
            this.SaveStripMenuItem.Enabled = false;
        }
        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit ??", "Exit",
                                     MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            
        }
        private void main_Load(object sender, EventArgs e)
        {
            

        }
        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (e.Item.Text.Length == 0)
            {
                e.Item.Visible = false;
            }
        }
        private void main_KeyDown(object sender, KeyEventArgs e)
        {
            //Save
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFile();
            }
        }
        #region Tool bar
        private void NewtoolStripButton_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void OpentoolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SavetoolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void ImporttoolStripButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Menu bar
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (editor != null)
            //{
            //    var entity = ConfigureModel.Find(editor.Project.ConnectionName);
            //    entity.DbName = editor.Project.DbName;
            //    using (DbContext context = new DbContext(entity))
            //    {
            //        ProjectModel model = new ProjectModel();
            //        var _columns = context.GetColumns(editor.Project.Tables.Select(p => p.Table_Name).ToArray());
            //        foreach (var item in editor.Project.Tables)
            //        {
            //            var columns = _columns.Where(p => p.Table == item.Table_Name);
            //            item.Object_id = columns.First().Object_id;
            //            foreach (var column in item.Columns)
            //            {
            //                var co = _columns.FirstOrDefault(p => p.Column == column.Column);
            //                column.Column_id = co.Column_id;
            //            }
            //        }
            //        await model.SaveAsync(editor.Project);
            //    }

            //}

        }
        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var connmgmt = new connectmgmt();
            connmgmt.ShowDialog();
        }
        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
        private void SaveStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        #endregion
        #region Private Method
        private async void SaveFile()
        {
            var editor = this.ActiveMdiChild as editor;
            if (editor != null)
            {
                ProjectModel model = new ProjectModel();
                if (await model.SaveAsync(editor.Project))
                {
                    this.SendNotify("Save succeeded.");
                }
                else
                {
                    this.SendNotify("Save failure.");

                }
            }
        }
        private async void OpenFile()
        {
            this.ClearNotify();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //this.MdiChildren.ToList().ForEach(p => p.Close());
                ProjectModel model = new ProjectModel();
                var project = await model.LoadAsync(openFileDialog.FileName);
                if (project != null)
                {
                    var editor = new editor(project);
                    editor.MdiParent = this;
                    editor.Dock = DockStyle.Fill;
                    editor.Show();
                    editor.Focus();
                    editor.WindowState = FormWindowState.Maximized;
                    this.SaveStripMenuItem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("this file can't open.", "Error");
                }
            }
        }
        private void NewFile()
        {
            this.ClearNotify();
            saveFileDialog.Title = "Choose new project file folder";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.Filter = "json files (*.json)|*.json|project files (*.sdj)|*.sdj";
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var frm = new newprojfrm(saveFileDialog.FileName);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // this.MdiChildren.ToList().ForEach(p => p.Close());
                    frm.Project.SavePath = saveFileDialog.FileName;
                    var editor = new editor(frm.Project);
                    editor.MdiParent = this;
                    editor.Dock = DockStyle.Fill;
                    editor.Show();
                    editor.Focus();
                    editor.WindowState = FormWindowState.Maximized;
                    this.SaveStripMenuItem.Enabled = true;
                }

            }
        }
        #endregion
    }
}
