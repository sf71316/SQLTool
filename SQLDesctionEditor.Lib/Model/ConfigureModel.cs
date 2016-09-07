using SQLDesctionEditor.Lib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace SQLDesctionEditor.Lib.Model
{
    public class ConfigureModel
    {
        static IEnumerable<ConnectionEntity> Connections;
        public IEnumerable<ConnectionEntity> GetConnectionList(string FileName)
        {
            var _fullpath = Path.Combine(Environment.CurrentDirectory, FileName);
            if (File.Exists(_fullpath))
            {
                var content = File.ReadAllText(_fullpath);
                return JsonConvert.DeserializeObject<IEnumerable<ConnectionEntity>>(content);
            }
            return new List<ConnectionEntity>();
        }
        public void Save(IEnumerable<ConnectionEntity> Data, string FileName)
        {
            var _fullpath = Path.Combine(Environment.CurrentDirectory, FileName);
            File.WriteAllText(_fullpath, JsonConvert.SerializeObject(Data, Formatting.Indented), Encoding.UTF8);
        }
        public static IEnumerable<ConnectionEntity> GetDefaultConnectionList()
        {
            if (Connections == null)
            {
                ConfigureModel model = new ConfigureModel();
                Connections = model.GetConnectionList(Configure.DEFAULT_CONNECTION_CONFIG_NAME).ToList();
            }
            return Connections;

        }
        public static ConnectionEntity Find(string ConnectionName, string FilePath = "")
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                return GetDefaultConnectionList().FirstOrDefault(p => p.ConnectionName == ConnectionName);
            }
            else
            {
                ConfigureModel model = new ConfigureModel();
                return model.GetConnectionList(FilePath).FirstOrDefault(p => p.ConnectionName == ConnectionName);
            }
        }
        public static void ClearCache()
        {
            Connections = null;
        }

    }
}
