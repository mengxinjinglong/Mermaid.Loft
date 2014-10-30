using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mermaid.Loft.Infrastructure.DBUtil;
using Mermaid.Loft.Infrastructure.DomainBase;

namespace Mermaid.Loft.Infrastructure.Repositories.Products
{
    public class ProductRepository<T> : DapperHelper<T> where T : EntityBase
    {
        public void Insert()
        {
            using (var connection = OpenConnection())
            { 
                
            }
        }
    }
}
