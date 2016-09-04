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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var connmgmt = new connectmgmt();
            connmgmt.ShowDialog();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Choose project file folder";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.Filter = "json files (*.json)|*.json|project files (*.sdj)|*.sdj";
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var frm =new newprojfrm(saveFileDialog.FileName);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.MdiChildren.ToList().ForEach(p => p.Close());
                    frm.Project.SavePath = saveFileDialog.FileName;
                    var editor = new editor(frm.Project);
                    editor.MdiParent = this;
                    editor.Dock = DockStyle.Fill;
                    editor.WindowState = FormWindowState.Maximized;
                    editor.TopLevel = false;
                    editor.Show();
                }

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.MdiChildren.ToList().ForEach(p => p.Close());
                ProjectModel model = new ProjectModel();
                var project = await model.LoadAsync(openFileDialog.FileName);
                var editor = new editor(project);
                editor.MdiParent = this;
                editor.Dock = DockStyle.Fill;
                editor.WindowState = FormWindowState.Maximized;
                editor.TopLevel = false;
                editor.Show();
            }
        }
    }
}
