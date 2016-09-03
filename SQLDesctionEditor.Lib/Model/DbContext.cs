using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using General.Data;
using SQLDesctionEditor.Lib.Entity;
using Dapper;

namespace SQLDesctionEditor.Lib.Model
{
    public class DbContext : DataBase, IDisposable
    {
        public DbContext()
        {

        }
        public DbContext(ConnectionEntity Entity)
        {
            this.InitDataBase(GetConnectionString(Entity));
        }
        public IList<string> GetDataBases()
        {
            using (var conn = this.Provider.GenerateConnection())
            {
              var result=  conn.Query<DataBaseEntity>("EXEC sp_databases");
                
                return result.Where(p => 
                     !new string[] { "master", "tempdb","msdb" }.Contains(p.DATABASE_NAME)
                ).Select(p=>p.DATABASE_NAME).ToList();
            }
        }
        public static string GetConnectionString(string serverName,
            bool isWindowsAuth = false, string UserId = "", string password = "", DbBase type = DbBase.SQLServer)
        {
            switch (type)
            {
                case DbBase.SQLServer:
                    return generateString(serverName, isWindowsAuth, UserId, password, type);
                case DbBase.MySQL:
                    return "";
                case DbBase.Oracle:
                    return "";
                default:
                    return "";
            }

        }
        public static string GetConnectionString(ConnectionEntity entity, DbBase type = DbBase.SQLServer)
        {
            switch (type)
            {
                case DbBase.SQLServer:
                    return generateString(entity.ServerName, entity.WindowsAuthentication,
                            entity.UserId, entity.Password, type);
                case DbBase.MySQL:
                    return "";
                case DbBase.Oracle:
                    return "";
                default:
                    return "";
            }

        }
        public void InitDataBase(string connectstring, SQLType type = SQLType.MSSQL)
        {
            this.GenerateDataBase(connectstring, type);
        }
        public async static Task<bool> TestConnect(string connectionstring, SQLType type = SQLType.MSSQL)
        {
            var db = new DbContext();
            db.InitDataBase(connectionstring, type);

            using (var conn = db.Provider.GenerateConnection())
            {
                try
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

        }
        private static string generateString(string serverName, bool isWindowsAuth, string userId, string password, DbBase type)
        {
            var stringbuilder = new System.Data.SqlClient.SqlConnectionStringBuilder()
            {
                DataSource = serverName,
                InitialCatalog = Configure.DEFAULT_DATABASE_NAME
            };
            if (!isWindowsAuth)
            {
                stringbuilder.UserID = userId;
                stringbuilder.Password = password;
            }
            else
            {
                stringbuilder.IntegratedSecurity = true;
            }
            return stringbuilder.ConnectionString;
        }

    }
}
