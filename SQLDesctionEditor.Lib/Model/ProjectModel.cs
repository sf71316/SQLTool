using Newtonsoft.Json;
using SQLDesctionEditor.Lib.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
