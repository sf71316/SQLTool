﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDesctionEditor.Lib.Controls
{
    public class TextboxBtn:TextBox
    {
        private readonly Button _button;
        public TextboxBtn()
        {
            _button = new Button { Cursor = Cursors.Default };
            _button.SizeChanged += (o, e) => OnResize(e);
            this.Controls.Add(_button);
        }

        public Button Button
        {
            get
            {
                return _button;
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            _button.Size = new Size(20, this.ClientSize.Height + 2);
            _button.Location = new Point(this.ClientSize.Width - _button.Width, -1);
            // Send EM_SETMARGINS to prevent text from disappearing underneath the button
            SendMessage(this.Handle, 0xd3, (IntPtr)2, (IntPtr)(_button.Width << 16));
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
    }
}
