using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mermaid.Loft.Infrastructure.DomainBase;

namespace Mermaid.Loft.Infrastructure.DBUtil
{
    public class DapperHelper<T>:IRepository<T> where T: EntityBase
    {
        private const string CONNECTION = "Data Source=mermaid.db;Version=3;Password=mylofter123;";


        public DapperHelper()
        { 
            
        }

        public DbConnection OpenConnection()
        {
            var sqliteConnection = new SQLiteConnection(CONNECTION);
            sqliteConnection.Open();
            return sqliteConnection;
        }

    }
}
