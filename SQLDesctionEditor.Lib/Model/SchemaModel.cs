﻿using SQLDesctionEditor.Lib.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDesctionEditor.Lib.Model
{
    public class SchemaModel : Notification
    {
        public SchemaModel()
        {

        }
        public List<TableEntity> GetAllTableSchema(string ConnectionString, string ProviderName)
        {
            var config = new ConnectionEntity();
            config.ConnectionString = ConnectionString;
            config.ProviderName = ProviderName;
            using (DbContext db = new DbContext(config))
            {
                this.OnNotify("Loading tables....");
                var _tables = db.GetTables().OrderBy(P => P.Table_Name).ToList();
                this.OnNotify("Loading completed....");
                this.OnNotify("Loading all columns....");
                var _columns = db.GetColumns(_tables.Select(p => p.Table_Name).ToArray());
                this.OnNotify("Loading completed....");

                foreach (var item in _tables)
                {
                    item.Object_id = _columns.FirstOrDefault(p => p.Table == item.Table_Name).Object_id;
                    var columns = _columns.Where(p => p.Table == item.Table_Name);
                    item.Columns = new BindingList<ColumnEntity>(
                        columns.ToList());
                }
                return _tables;
            }

        }
        public List<TableEntity> GetRemainTable(IList<TableEntity> datasource
            , string ConnectionName, string DbName)
        {
            var config = ConfigureModel.Find(ConnectionName);
            using (DbContext db = new DbContext(config))
            {
                var exists = datasource.Select(s => s.Object_id);
                var _tables = db.GetTables().Where(p =>
                !exists.Contains(p.Object_id))
                .OrderBy(P => P.Table_Name).ToList();
                if (_tables.Count > 0)
                {
                    var _columns = db.GetColumns(_tables.Select(p => p.Table_Name).ToArray());
                    foreach (var item in _tables)
                    {
                        item.Object_id = _columns.First().Object_id;
                        var columns = _columns.Where(p => p.Table == item.Table_Name);
                        item.Columns = new BindingList<ColumnEntity>(
                            columns.ToList());
                    }
                    return _tables;
                }
                return null;

            }

        }
    }
}
