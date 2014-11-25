using Mermaid.Loft.Infrastructure.DBUtil;
using Mermaid.Loft.Model.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.Repositories.Products
{
    public class ProductRepository : DapperRepository<Product>,IProductRepository
    {
        public ProductRepository()
        {
            SQL_TABLE_CREATE = "create table product(ProductId varchar(255),ProductName varchar(255),Url varchar(255),UserId varchar(255),CreateDate datetime,SourceUrl varchar(255),Categories varchar(255),Description varchar(255),UpdateDate datetime)";

            SQL_INSERT = "insert into product(ProductId,ProductName,Url,UserId,CreateDate,SourceUrl,Categories,Description,UpdateDate) values(@ProductId,@ProductName,@Url,@UserId,@CreateDate,@SourceUrl,@Categories,@Description,@UpdateDate)";

            SQL_UPDATE = "update product set ProductName=@ProductName,Url=@Url,UserId=@UserId,CreateDate=@CreateDate,SourceUrl=@SourceUrl,Categories=@Categories,Description=Description,UpdateDate=@UpdateDate where ProductId=";

            SQL_DELETE_PHYSICAL = "delete from product where productId=@productId";

            SQL_SELECTBY = "select * from product where productId=@productId";

            SQL_SELECTALL = "select * from product";
        }

        public void CreateTable()
        {
            base.Create();
        }

        public void InsertItem(Product product)
        {
                base.Insert(product);
        }

        public void UpdateItem(Product product)
        {
                base.Update(product);
        }

        public void DeleteItemPhysical(Product product)
        {
            base.DeletePhysical(product);
        }

        public void DeleteItemLogic(Product product)
        {
            base.DeleteLogic(product);
        }

        public Product SelectItemBy(object id)
        {
            return base.SelectBy(new {ProductId=id.ToString()});
        }

        public IList<Product> SelectItemAll()
        {
            return base.SelectAll();
        }
    }
}
