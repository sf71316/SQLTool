using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SQLDesctionEditor.Lib.Entity;
using Dapper;

namespace SQLDesctionEditor.Lib.Model
{
    public class DbContext : DataBaseghost, IDisposable
    {
        public DbContext()
        {

        }
        public DbContext(ConnectionEntity Entity)
        {
            this.InitDataBase(Entity.ConnectionString,Entity.ProviderName);
        }
        public IList<string> GetDataBases()
        {
            using (var conn = this.Provider.GenerateConnection())
            {
                var result = conn.Query<DataBaseEntity>("EXEC sp_databases");

                return result.Where(p =>
                     !new string[] { "master", "tempdb", "msdb" }.Contains(p.DATABASE_NAME)
                ).Select(p => p.DATABASE_NAME).ToList();
            }
        }
        public IList<TableEntity> GetTables()
        {
            using (var conn = this.Provider.GenerateConnection())
            {
                var result = conn.Query<TableEntity>(@"select name Table_Name,object_id from sys.tables
                                        WHERE type_desc='USER_TABLE' AND is_ms_shipped=0");
                return result.ToList();
            }

        }
        public List<ColumnEntity> GetColumns(string[] TableNames = null, int[] Object_id = null)
        {
            using (var conn = this.Provider.GenerateConnection())
            {
                if (TableNames != null)
                {
                    var result = conn.Query<ColumnEntity>(@"
                select distinct
                    st.name [Table],
                    sc.name [Column],
	                sc.object_id,
					sc.column_id,
		            COLUMN_DEFAULT ColumnDefault,isc.IS_NULLABLE ISNULLABLE,DATA_TYPE DataType,CHARACTER_MAXIMUM_LENGTH [Length],
                    sep.value [Description],
					t.modify_date LastModifiedOn
                from sys.tables st
                inner join sys.columns sc on st.object_id = sc.object_id
	            inner join INFORMATION_SCHEMA.COLUMNS isc on isc.COLUMN_NAME=sc.name and isc.TABLE_NAME=st.name
                INNER JOIN sys.objects t on t.object_Id=st.object_Id 
                left join sys.extended_properties sep on st.object_id = sep.major_id
                                                     and sc.column_id = sep.minor_id
                                                     and sep.name = 'MS_Description'
                where st.name in @TableNames AND is_ms_shipped=0
	            order by st.name,sc.name
                ", new { TableNames = TableNames });
                    return result.ToList();
                }
                else if (Object_id != null)
                {
                    var result = conn.Query<ColumnEntity>(@"
                select distinct
                    st.name [Table],
                    sc.name [Column],
	                sc.object_id,
					sc.column_id,
		            COLUMN_DEFAULT ColumnDefault,isc.IS_NULLABLE ISNULLABLE,DATA_TYPE DataType,CHARACTER_MAXIMUM_LENGTH [Length],
                    sep.value [Description]
                from sys.tables st
                inner join sys.columns sc on st.object_id = sc.object_id
	            inner join INFORMATION_SCHEMA.COLUMNS isc on isc.COLUMN_NAME=sc.name and isc.TABLE_NAME=st.name
                left join sys.extended_properties sep on st.object_id = sep.major_id
                                                     and sc.column_id = sep.minor_id
                                                     and sep.name = 'MS_Description'
                where sc.object_id in @Object_id AND is_ms_shipped=0
	            order by st.name,sc.column_id
                ", new { Object_id = Object_id });
                    return result.ToList();
                }
                else
                {
                    var result = conn.Query<ColumnEntity>(@"
                select distinct
                    st.name [Table],
                    sc.name [Column],
	                sc.object_id,
					sc.column_id,
		            COLUMN_DEFAULT ColumnDefault,isc.IS_NULLABLE ISNULLABLE,DATA_TYPE DataType,CHARACTER_MAXIMUM_LENGTH [Length],
                    sep.value [Description]
                from sys.tables st
                inner join sys.columns sc on st.object_id = sc.object_id
	            inner join INFORMATION_SCHEMA.COLUMNS isc on isc.COLUMN_NAME=sc.name and isc.TABLE_NAME=st.name
                left join sys.extended_properties sep on st.object_id = sep.major_id
                                                     and sc.column_id = sep.minor_id
                                                     and sep.name = 'MS_Description'
                where  is_ms_shipped=0
	            order by st.name,sc.name
                ");
                    return result.ToList();
                }
            }
        }
        public void InitDataBase(string connectstring, string providerName)
        {
            this.GenerateDataBase(connectstring, providerName);
        }
        private static string generateString(string serverName, bool isWindowsAuth, string userId, string password, DbBase type, string dbname = "")
        {
            var stringbuilder = new System.Data.SqlClient.SqlConnectionStringBuilder()
            {
                DataSource = serverName,
                InitialCatalog = Configure.DEFAULT_DATABASE_NAME
            };
            if (!string.IsNullOrEmpty(dbname))
                stringbuilder.InitialCatalog = dbname;
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
        public void Dispose()
        {

        }
    }
}
