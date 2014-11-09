using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mermaid.Loft.Infrastructure.DomainBase;
using System.Data;
using Dapper;

namespace Mermaid.Loft.Infrastructure.DBUtil
{
    public abstract class DapperRepository<T>:IRepository<T> where T: EntityBase
    {
        private static readonly string CONNECTION = "Data Source="+Environment.CurrentDirectory+@"\mermaid.db;Version=3;Password=mylofter123;";

        public string SQL_CREATE = string.Empty;

        public string SQL_INSERT = string.Empty;

        public string SQL_UPDATE = string.Empty;

        public string SQL_DELETE = string.Empty;

        public string SQL_SELECTBY = string.Empty;

        public string SQL_SELECTALL = string.Empty;

        public DapperRepository()
        {
            
        }

        public IDbConnection OpenConnection()
        {
            var sqliteConnection = new SQLiteConnection(CONNECTION);
            sqliteConnection.Open();
            return sqliteConnection;
        }

        private IList<T> Query(string sql, object obj)
        {
            using (IDbConnection connection = OpenConnection())
            {
                return connection.Query<T>(sql, obj).ToList();
            }
        }

        private void Execute(string sql, T entity)
        {
            using (IDbConnection connection = OpenConnection())
            {
                connection.Execute(sql, entity);
            }
        }

        #region - Public Method -
        public void Create()
        {
            this.Execute(SQL_CREATE,null);
        }
        public void Insert(T entity)
        {
            this.Execute(SQL_INSERT, entity);
        }

        public void Update(T entity)
        {
            this.Execute(SQL_UPDATE, entity);
        }

        public void Delete(T entity)
        {
            this.Execute(SQL_DELETE, entity);
        }

        public T SelectBy(object obj)
        {
            return this.Query(SQL_SELECTBY, obj).FirstOrDefault();
        }

        public IList<T> SelectAll()
        {
            return this.Query(SQL_SELECTALL, null);
        }
        #endregion

    }
}
