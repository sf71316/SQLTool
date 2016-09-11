using Newtonsoft.Json;
using SQLDesctionEditor.Lib.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDesctionEditor.Lib.Model
{
    public class ProjectModel : Notification
    {
        public ProjectModel()
        {

        }
        public ProjectEntity Create(string ConnectionName, string DbName)
        {
            var proj = new ProjectEntity();
            proj.ConnectionName = ConnectionName;
            proj.DbName = DbName;
            SchemaModel model = new Model.SchemaModel();
            proj.Tables = model.GetAllTableSchema(ConnectionName, DbName);
            return proj;
        }
        public async Task<ProjectEntity> LoadAsync(string FilePath)
        {
            var project = await Task.Run(() =>
            {
                try
                {
                    return JsonConvert.DeserializeObject<ProjectEntity>(
                     File.ReadAllText(FilePath));
                }
                catch
                {
                    return null;
                }
            });
            return project;
        }
        public async Task<bool> SaveAsync(ProjectEntity data)
        {
            try
            {
                bool _isallow = true;
                if (File.Exists(data.SavePath))
                {
                    if (FileExist != null)
                        _isallow = FileExist();
                }
                if (_isallow)
                {
                    await Task.Run(() =>
                     {
                         var content = JsonConvert.SerializeObject(data, Formatting.Indented);
                         File.WriteAllText(data.SavePath, content);
                     });

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Func<bool> FileExist { get; set; }
        public void UpdateSchema(TableEntity _table, bool iswithoutdesc, bool isoriginal
            , ConnectionEntity _config, Func<Delegate, object> WinUIthread)
        {
            using (DbContext db = new DbContext(_config))
            {
                this.OnNotify("Get column data....");
                List<ColumnEntity> columns;
                if (isoriginal)
                    columns = db.GetColumns(Object_id: new int[] { _table.Object_id });
                else
                    columns = db.GetColumns(TableNames: new string[] { _table.Table_Name });
                if (columns.Count > 0)
                {

                    this.OnNotify("Begin compare data....");
                    var t = columns.First();
                    if (_table.Table_Name != t.Table)
                    {
                        _table.Table_Name = t.Table;
                    }
                    this.ModifiyTableSchema(columns, _table, WinUIthread, isoriginal, iswithoutdesc);


                    this.OnNotify("Complete.");
                }
                else
                {
                    this.OnNotify("Not find table please try again.");
                }
            }
        }
        private void ModifiyTableSchema(List<ColumnEntity> sources, TableEntity _table, Func<Delegate, object> WinUI,
          bool isoriginal=false, bool iswithoutdesc = false)
        {
            foreach (var item in _table.Columns)
            {
                ColumnEntity source;
                source = sources.Where(x => x.Object_id == _table.Object_id)
                    .FirstOrDefault(p => p.Column_id == item.Column_id || p.Column == item.Column);
                if (source != null)
                {
                    item.Column_id = source.Column_id;
                    item.Column = source.Column;
                    item.ColumnDefault = source.ColumnDefault;
                    item.DataType = source.DataType;
                    item.Length = source.Length;
                    item.ISNULLABLE = source.ISNULLABLE;
                    if (!iswithoutdesc)
                    {
                        if (!string.IsNullOrEmpty(source.Description))
                            item.Description = source.Description;
                    }
                }
            }

            if (isoriginal)
            {
                var newcolumns = sources.Select(p => p.Column_id).ToList().Except(
                        _table.Columns.Select(p => p.Column_id)
                    );
                // add columns
                sources.Where(p => newcolumns.Contains(p.Column_id)).ToList().ForEach(p =>
                {
                    WinUI.Invoke(new Action(() =>
                    {
                        _table.Columns.Add(p);
                    }));

                });
                var removecolumns = _table.Columns.Select(p => p.Column_id).ToList().Except(
                       sources.Select(p => p.Column_id)
                   );
                //remove columns
                for (int i = 0; i < _table.Columns.Count; i++)
                {
                    if (removecolumns.Contains(_table.Columns[i].Column_id))
                    {
                        WinUI.Invoke(new Action(() =>
                        {
                            _table.Columns.RemoveAt(i);
                        }));
                    }
                }
            }
        }
        public void SyncExistsTable(ProjectEntity project, Func<Delegate, object> WinUIthread)
        {
            var _config = ConfigureModel.Find(project.ConnectionName);
            _config.DbName = project.DbName;
            using (DbContext db = new DbContext(_config))
            {
                var _objectid = project.Tables.Select(t => t.Object_id);
                var _tablename = project.Tables.Select(t => t.Table_Name);
                this.OnNotify("Get table data....");
                var tables = db.GetTables().Where(p =>
                _objectid.Contains(p.Object_id)||
                _tablename.Contains(p.Table_Name));
                this.OnNotify("Get column data....");
                List<ColumnEntity> columns =
                db.GetColumns(Object_id: project.Tables.Select(t => t.Object_id).ToArray());
                this.OnNotify("Begin remove table....");
                //remove table
                var removetables = project.Tables.Select(p => p.Object_id).ToList().Except(
                              tables.Select(p => p.Object_id).ToList()
                          );
                for (int i = 0; i < project.Tables.Count; i++)
                {
                    if (removetables.Contains(project.Tables[i].Object_id))
                    {
                        WinUIthread.Invoke(new Action(() =>
                        {
                            project.Tables.RemoveAt(i);
                        }));
                    }
                }
                this.OnNotify("Begin modify table ....");
                foreach (var item in project.Tables)
                {
                    this.OnNotify("Sync " + item.Table_Name);
                    this.ModifiyTableSchema(columns, item, WinUIthread, iswithoutdesc: true);
                }
                this.OnNotify("Complete.");
            }
        }
        public List<TableEntity> GetRemainTable(ProjectEntity project)
        {
            SchemaModel model = new SchemaModel();
            return model.GetRemainTable(project.Tables, project.ConnectionName, project.DbName);
        }
    }
}
