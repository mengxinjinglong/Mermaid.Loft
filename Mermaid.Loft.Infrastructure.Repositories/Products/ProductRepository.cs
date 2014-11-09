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
    public class ProductRepository : DapperRepository<Product>,IRepository<Product>
    {
        public ProductRepository()
        {
            base.SQL_CREATE = "create table product(ProductId varchar(255),ProductName varchar(255),Url varchar(255),UserId varchar(255),CreateDate datetime,SourceUrl varchar(255),Categories varchar(255),Description varchar(255),UpdateDate datetime)";

            SQL_INSERT = "insert into product(ProductId,ProductName,Url,UserId,CreateDate,SourceUrl,Categories,Description,UpdateDate) values(@ProductId,@ProductName,@Url,@UserId,@CreateDate,@SourceUrl,@Categories,@Description,@UpdateDate)";

            SQL_UPDATE = "update product set ProductName=@ProductName,Url=@Url,UserId=@UserId,CreateDate=@CreateDate,SourceUrl=@SourceUrl,Categories=@Categories,Description=Description,UpdateDate=@UpdateDate where ProductId=";

            SQL_DELETE = "delete from product where productId=@productId";

            SQL_SELECTBY = "select * from product where productId=@productId";

            SQL_SELECTALL = "select * from product";
        }
        public void CreateItem()
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

        public void DeleteItem(Product product)
        {
            base.Delete(product);
        }

        public Product SelectByItem(string id)
        {
            return base.SelectBy(new {ProductId=id});
        }

        public IList<Product> SelectAllItem()
        {
            return base.SelectAll();
        }
    }
}
