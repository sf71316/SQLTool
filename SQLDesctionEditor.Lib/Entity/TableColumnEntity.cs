using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDesctionEditor.Lib.Entity
{
    public class TableColumnEntity
    {
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public bool IsNull { get; set; }
        public string DefaultValue { get; set; }
        public string Description { get; set; }
    }
}
