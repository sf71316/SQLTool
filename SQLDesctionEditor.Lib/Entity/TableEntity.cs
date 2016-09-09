using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SQLDesctionEditor.Lib.Entity
{
    public class TableEntity: INotifyPropertyChanged
    {
        private string _Description;

        public string Table_Name { get; set; }
        public int Object_id { get; set; }
        public string Description
        {
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
        public BindingList<ColumnEntity> Columns { get; set; }
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
