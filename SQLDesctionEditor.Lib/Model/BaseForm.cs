using SQLDesctionEditor.Lib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDesctionEditor.Lib.Model
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        protected static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        protected static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        public void SendNotify(string message)
        {
            var statusbar = FindBar();
            if (statusbar != null)
            {
                statusbar.Text = message;
            }
        }
        public void ClearNotify()
        {
            var statusbar = FindBar();
            if (statusbar != null)
            {
                statusbar.Text = string.Empty;

            }
        }
        private ToolStripStatusLabel FindBar()
        {
            //StatusLabel
            //ToolStripStatusLabel
            var container = this as Control;
            if (this.Parent != null)
            {
                if (this.Parent.Parent != null)
                    container = this.Parent.Parent;
                else
                    container = this.Parent;
            }
            foreach (Control item in container.Controls)
            {
                if (item is StatusStrip && item.Name == "statusStrip")
                {
                    var bar = item as StatusStrip;
                    return bar.Items[0] as ToolStripStatusLabel;
                }
            }
            return null;
        }
        protected void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo aProp =
                  typeof(System.Windows.Forms.Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }

    }
}
