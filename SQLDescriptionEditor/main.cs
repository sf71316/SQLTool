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
        editor editor = null;
        public main()
        {
            InitializeComponent();
            this.SaveStripMenuItem.Enabled = false;
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var connmgmt = new connectmgmt();
            connmgmt.ShowDialog();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClearNotify();
            saveFileDialog.Title = "Choose project file folder";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.Filter = "json files (*.json)|*.json|project files (*.sdj)|*.sdj";
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var frm = new newprojfrm(saveFileDialog.FileName);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.MdiChildren.ToList().ForEach(p => p.Close());
                    frm.Project.SavePath = saveFileDialog.FileName;
                    editor = new editor(frm.Project);
                    editor.MdiParent = this;
                    editor.Dock = DockStyle.Fill;
                    editor.WindowState = FormWindowState.Maximized;
                    editor.TopLevel = false;
                    editor.Show();
                    this.SaveStripMenuItem.Enabled = true;
                }

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClearNotify();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.MdiChildren.ToList().ForEach(p => p.Close());
                ProjectModel model = new ProjectModel();
                var project = await model.LoadAsync(openFileDialog.FileName);
                if (project != null)
                {
                    editor = new editor(project);
                    editor.MdiParent = this;
                    editor.Dock = DockStyle.Fill;
                    editor.WindowState = FormWindowState.Maximized;
                    editor.TopLevel = false;
                    editor.Show();
                    this.SaveStripMenuItem.Enabled = true;
                }else
                {
                    MessageBox.Show("this file can't open.","Error");
                }
            }
        }

        private void SaveStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
        private async void Save()
        {
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
            #region unregister hotkey
            UnregisterHotKey(this.Handle, this.GetType().GetHashCode());
            #endregion
        }
        private void main_Load(object sender, EventArgs e)
        {
            #region register hotkey
            var modifierKeys = (int)(System.Windows.Input.ModifierKeys.Control);
            var virtualKey = (int)KeyInterop.VirtualKeyFromKey(Key.S);
            RegisterHotKey(this.Handle, this.GetType().GetHashCode(), modifierKeys, virtualKey);
            #endregion

        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                if (editor != null)
                {
                    var vk = (ushort)(m.LParam.ToInt32() >> 16);//virtual key code
                    var key = KeyInterop.KeyFromVirtualKey(vk);
                    if (key == Key.S)
                    {
                        this.ClearNotify();
                        Save();
                    }
                }
            }
            base.WndProc(ref m);
        }

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

 
    }
}
