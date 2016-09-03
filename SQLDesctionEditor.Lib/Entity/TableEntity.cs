using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDesctionEditor.Lib.Entity
{
    public class TableEntity
    {
        public string TableName { get; set; }
        public IList<TableColumnEntity> Columns { get; set; }
    }
}
