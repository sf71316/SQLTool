using SQLDesctionEditor.Lib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDesctionEditor.Lib.Model
{
    public class SubFormTransferArgs:EventArgs
    {
        public ProjectEntity Project { get; set; }
    }
}
