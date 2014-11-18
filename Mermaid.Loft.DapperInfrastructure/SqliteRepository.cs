using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.Dapper
{
    public class SqliteRepository
    {
        private static readonly string DB_FILE = AppDomain.CurrentDomain + @"\repository.sqlite";
        private static readonly string CONNECTION = DB_FILE + @";Version=3;Password=mylofter123;";
        
        public void CheckDb()
        {
            if(File.Exists(DB_FILE))
            {
                File.Create(DB_FILE);
            }
        }
        public IDbConnection OpenConnection()
        {
            var sqliteConnection = new SQLiteConnection(CONNECTION);
            sqliteConnection.Open();
            return sqliteConnection;
        }
    }
}
