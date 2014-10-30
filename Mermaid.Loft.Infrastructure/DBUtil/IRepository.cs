using Mermaid.Loft.Infrastructure.DomainBase;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.DBUtil
{
    public interface IRepository<T> where T : EntityBase
    {
        public DbConnection OpenConnection();
    }
}
