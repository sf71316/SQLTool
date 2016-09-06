﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SQLDesctionEditor.Lib.Entity
{
    public class ProjectEntity
    {
        public string ConnectionName { get; set; }
        public string SavePath { get; set; }
        public string DbName { get; set; }
        public string ProjectName { get; set; }
        public IList<TableEntity> Tables { get; set; }
    }
}
