using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Mermaid.Loft.Infrastructure.Dapper;

namespace Mermaid.Loft.Infrastructure.TestUnit.DapperTest
{
    [TestClass]
    public class SqliteRepositoryTest
    {
        [TestMethod]
        public void Init()
        {
            var repository = new SqliteRepository();
            repository.CheckDb();
            //var connect = repository.OpenConnection();
        }
    }
}
