using SQLDesctionEditor.Lib.Entity;
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
        public List<TableEntity> DataSource { get; set; }
        private void btnsync_Click(object sender, EventArgs e)
        {
            if (rbaddtable.Checked)
            {

            }else
            {
                SyncExistsTable();
            }
        }
        private void SyncExistsTable()
        {
            
        }
    }
}
