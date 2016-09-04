using Newtonsoft.Json;
using SQLDesctionEditor.Lib.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDesctionEditor.Lib.Model
{
    public class ProjectModel : Notification
    {
        string _connName;
        string _dbName;
        public ProjectModel()
        {

        }
        public ProjectModel(string ConnectionName, string DbName)
        {
            this._connName = ConnectionName;
            this._dbName = DbName;
        }
        public ProjectEntity Create()
        {
            var proj = new ProjectEntity();
            var config = ConfigureModel.Find(this._connName);
            config.DbName = this._dbName;
            using (DbContext db = new DbContext(config))
            {
                this.OnNotify("Loading tables....");
                var _tables = db.GetTables();
                this.OnNotify("Loading completed....");
                this.OnNotify("Loading all columns....");
                var _columns = db.GetColumns(_tables.Select(p => p.Table_Name).ToArray());
                this.OnNotify("Loading completed....");
                proj.ConnectionName = _connName;
                proj.DbName = _dbName;
                proj.Tables = _tables;
                foreach (var item in proj.Tables)
                {
                    var columns = _columns.Where(p => p.Table == item.Table_Name);
                    item.Columns = columns.ToList();
                }
            }
            return proj;
        }
        public async Task<ProjectEntity> LoadAsync(string FilePath)
        {
            var project = await Task.Run(() =>
            {
                return JsonConvert.DeserializeObject<ProjectEntity>(
                 File.ReadAllText(FilePath));
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
    }
}
