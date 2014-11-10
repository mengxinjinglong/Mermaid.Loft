using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mermaid.Loft.Model.Products;
using Mermaid.Loft.Infrastructure.Repository;

namespace Mermaid.Loft.Infrastructure.Repositories.Products
{
    public interface IProductRepository:IRepository<Product>
    {
    }
}
