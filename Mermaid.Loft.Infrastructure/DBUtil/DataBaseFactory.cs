using Mermaid.Loft.Infrastructure.DomainBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.DBUtil
{
    public class DataBaseFactory<T> where T: EntityBase
    {
        public RepositoryBase<T> GetInstance(string type)
        {
            //return new DapperRepository<T>();
            return null;
        }
    }
}
