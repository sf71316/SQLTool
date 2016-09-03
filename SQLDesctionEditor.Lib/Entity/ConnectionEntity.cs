using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDesctionEditor.Lib.Entity
{
    public class ConnectionEntity
    {
        public string  ConnectionName { get; set; }
        public string ServerName { get; set; }
        public string ProviderName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
