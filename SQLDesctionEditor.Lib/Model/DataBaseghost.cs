using System;
using System.Data.Common;

namespace SQLDesctionEditor.Lib.Model
{
    public abstract class DataBaseghost
    {

        public ProviderBase Provider { get; protected set; }
        protected void GenerateDataBase(string connectionstring, string providername)
        {
            this.Provider = new ProviderBase(connectionstring, providername);
        }
    }
    public class ProviderBase
    {
        protected DbCommand _cmd;
        protected DbConnection _conn;
        protected DbProviderFactory _provider;
        protected string _connstr;
        public ProviderBase(string connectionstring,string providername)
        {
            _connstr = connectionstring;
            _provider = DbProviderFactories.GetFactory(providername);
            _conn = _provider.CreateConnection();
            _conn.ConnectionString = connectionstring;
        }
        public DbConnection Connection { get; set; }

        public DbConnection GenerateConnection()
        {
            var _conn = _provider.CreateConnection();
            _conn.ConnectionString = _connstr;
            return _conn;
        }
    }
    public enum SQLType
    {
        MSSQL
    }
}