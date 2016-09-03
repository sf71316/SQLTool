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
    }
}
