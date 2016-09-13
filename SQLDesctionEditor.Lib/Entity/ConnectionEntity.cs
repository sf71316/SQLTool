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
        public string  ConnectionString { get; set; }
        public string ProviderName { get; set; }
    }
}
