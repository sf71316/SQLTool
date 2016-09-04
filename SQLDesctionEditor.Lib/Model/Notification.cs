using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDesctionEditor.Lib.Model
{
    public abstract class Notification
    {
        public event EventHandler<NotifyArg> Notify;
        protected void OnNotify(string Message)
        {
            if (this.Notify != null)
            {
                this.Notify(this, new NotifyArg { Message = Message });
            }
        }
    }
    public class NotifyArg:EventArgs
    {
        public string Message { get; set; }
    }
}
