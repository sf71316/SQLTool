using SQLDesctionEditor.Lib.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDesctionEditor.Lib.Model
{
    public class SchemaModel: Notification
    {
        public SchemaModel()
        {

        }
        public List<TableEntity> GetAllTableSchema(string ConnectionName, string DbName)
        {
            var config = ConfigureModel.Find(ConnectionName);
            config.DbName = DbName;
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
                    item.Object_id = _columns.First().Object_id;
                    var columns = _columns.Where(p => p.Table == item.Table_Name);
                    item.Columns = new BindingList<TableColumnEntity>(
                        columns.ToList());
                }
                return _tables;
            }
            
        }
    }
}
