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
                }catch
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
            , ConnectionEntity _config, Func<Delegate, object> WinUI)
        {
            using (DbContext db = new Model.DbContext(_config))
            {
                this.OnNotify("get column data....");
                List<TableColumnEntity> columns;
                if(isoriginal)
                    columns = db.GetColumns(Object_id: new int[] { _table.Object_id });
                else
                    columns = db.GetColumns(TableNames: new string[] { _table.Table_Name });
                if (columns.Count > 0)
                {
                   
                        this.OnNotify("begin compare data....");
                        var t = columns.First();
                        if (_table.Table_Name != t.Table)
                        {
                            _table.Table_Name = t.Table;
                        }
                        foreach (var item in _table.Columns)
                        {
                            TableColumnEntity source;
                            if(isoriginal)
                                source = columns.FirstOrDefault(p => p.Column_id == item.Column_id);
                            else
                                source = columns.FirstOrDefault(p => p.Column == item.Column);
                            if (source != null)
                            {
                                item.Column = source.Column;
                                item.ColumnDefault = source.ColumnDefault;
                                item.DataType = source.DataType;
                                item.Length = source.Length;
                                item.ISNULLABLE = source.ISNULLABLE;
                                if (!iswithoutdesc)
                                    item.Description = source.Description;
                            }
                        }
                        if (isoriginal)
                        {
                            var newcolumns = columns.Select(p => p.Column_id).ToList().Except(
                                    _table.Columns.Select(p => p.Column_id)
                                );
                            var removecolumns = _table.Columns.Select(p => p.Column_id).ToList().Except(
                                    columns.Select(p => p.Column_id)
                                );
                            // add columns
                            columns.Where(p => newcolumns.Contains(p.Column_id)).ToList().ForEach(p =>
                            {

                                WinUI.Invoke(new Action(() =>
                                {
                                    _table.Columns.Add(p);
                                }));

                            });
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

                        this.OnNotify("Complete.");
                }
                else
                {
                    this.OnNotify("not find table please try again.");
                }
            }
        }
    }
}
