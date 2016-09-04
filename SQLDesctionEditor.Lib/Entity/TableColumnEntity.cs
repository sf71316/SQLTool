using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SQLDesctionEditor.Lib.Entity
{
    public class TableColumnEntity
    {
        [JsonIgnore]
        public string Table { get; set; }
        public string Column { get; set; }
        public string DataType { get; set; }
        public int Length { get; set; }
        public string ISNULLABLE { get; set; }
        public string ColumnDefault { get; set; }
        public string Description { get; set; }
    }
}
