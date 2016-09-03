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
        public connectmgmt()
        {
            InitializeComponent();
            cbtemplate.SelectedIndex = 0;
        }

        private void cbAuthmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuthmode.SelectedIndex == 1)
            {
                this.plauth.Enabled = true;
            }else
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
            Save();
            this.Close();
        }
        private void Save()
        {

        }
        private void btntest_Click(object sender, EventArgs e)
        {

        }

        private void connectmgmt_Load(object sender, EventArgs e)
        {
            LoadConnectionDropdownList();
        }

        private void LoadConnectionDropdownList()
        {
            
        }
    }
}
