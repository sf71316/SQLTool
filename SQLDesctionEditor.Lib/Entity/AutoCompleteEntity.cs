using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDesctionEditor.Lib.Entity
{
    public class AutoCompleteEntity
    {
        public string Column { get; set; }
        public IEnumerable<string> Keyword { get; set; }
        
    }
}
