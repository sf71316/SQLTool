using SQLDesctionEditor.Lib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDesctionEditor.Lib.Model
{
    public class AutoCompleteDataSource
    {
        IEnumerable<TableEntity> _data;
        Dictionary<string, IEnumerable<string>> _datadata;
        public AutoCompleteDataSource(IEnumerable<TableEntity> data)
        {
            _data = data;
            _datadata = new Dictionary<string, IEnumerable<string>>();
        }
        public void Generate()
        {
            var _source = _data.SelectMany(p => p.Columns).GroupBy(p=>p.Column);
            foreach (var item in _source)
            {
                var keywords = item.Where(p => !string.IsNullOrEmpty(p.Description))
                    .Select(x => x.Description)
                    .GroupBy(g=>g).Select(gi=>gi.Key).ToList();
                _datadata.Add(item.Key, keywords);
            }
        }
        public List<string> FindCompleteSource(string Column)
        {
            var result = this._datadata.FirstOrDefault(p => p.Key == Column).Value;
            if (result != null)
                return result.ToList();
            else
                return new List<string>();
        }
    }
}
