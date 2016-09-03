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
                frm.ShowDialog();
            }
        }
    }
}
