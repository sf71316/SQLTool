using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SQLDesctionEditor.Lib.Entity
{
    public class ColumnEntity: INotifyPropertyChanged
    {
        private string _Description;
        [JsonIgnore]
        public string Table { get; set; }
        [JsonIgnore]
        public int Object_id { get; set; }
        public string Column { get; set; }
        public int Column_id { get; set; }
        public string DataType { get; set; }
        public int Length { get; set; }
        public string ISNULLABLE { get; set; }
        public string ColumnDefault { get; set; }
        public string Description {
            get
            {
                return _Description;
            }
            set
            {
                if (value != this._Description)
                {
                    this._Description = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private void NotifyPropertyChanged([CallerMemberName] string propertyName="")
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
