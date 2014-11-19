using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mermaid.Loft.Infrastructure.Regular;
using Mermaid.Loft.Infrastructure.WebHttps;

using Mermaid.Loft.Infrastructure.Repositories;
using Mermaid.Loft.Model.Products;
using Mermaid.Loft.Infrastructure.Repositories.Products;
using Mermaid.Loft.Infrastructure.Repository;
using Mermaid.Loft.Infrastructure.AutoMapper;
using Autofac;
using System.Reflection;

namespace Mermaid.Loft.ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var source = "---zsd123@sdh@周升东.com===000";
            foreach (var item in source.Matches(@"\w@"))
                Console.WriteLine("the result is :" + item);

            var content = WebHttpsUtil.Reponse("http://detail.1688.com/offer/40710964384.html");
            //var content = WebHttpsUtil.Reponse("http://detail.1688.com/offer/41072925730.html");
            //var content = WebHttpsUtil.Reponse("http://detail.1688.com/offer/40843319449.html");
            Console.WriteLine(content.Match("<h1 class=\"d-title\">[\\s\\S]*</h1>"));

            var matches = content.Matches("<span class=\"text text-single-line\">[\\s\\S]{0,20}</span>");
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
             */
            IRepository<Product> repository = new ProductRepository();
            //repository.InsertItem(new Product {
            //    ProductId=Guid.NewGuid().ToString(),
            //    ProductName = "mylofter",
            //    UserId = "lofter",
            //    Categories="lofter-category",
            //    Description="this is the test category.",
            //    CreateDate = DateTime.Now.ToLocalTime(),
            //    UpdateDate = DateTime.Now.ToLocalTime()

            //});
            var entity = repository.SelectItemAll();
            Console.WriteLine("insert into the database finish.");
            IocMapper.Instance.RegistType(Assembly.GetAssembly(typeof(ProductRepository)));
            var rep = IocMapper.Instance.Container.Resolve<IRepository<Product>>();
            
            Console.ReadLine();
        }
    }
}
