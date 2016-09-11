using Microsoft.Data.ConnectionUI;
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
    public partial class ConnectionMgmt : Form
    {
        public ConnectionMgmt()
        {
            InitializeComponent();
        }

        private void btnOpenConnDialog_Click(object sender, EventArgs e)
        {
            using (var dialog = new DataConnectionDialog())
            {
                DataSource.AddStandardDataSources(dialog);
                dialog.DataSources.Add(DataSource.SqlDataSource);
                DialogResult userChoice = DataConnectionDialog.Show(dialog);

                if (userChoice == DialogResult.OK)
                {

                }
                else
                {

                }
            }
        }
    }
}
