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
            
            var source = "---zsd123@sdh@周升东.com===000";
            foreach (var item in source.Matches(@"\w@"))
                Console.WriteLine("the result is :" + item);

            //var url = "http://item.taobao.com/item.htm?spm=a1z10.3.w4002-5862495901.24.4dbx9k&id=42271148128";
            var url = "http://item.taobao.com/item.htm?spm=a1z10.1.w5003-6599201826.13.wVsA6V&id=38210095996&scene=taobao_shop";
            //"http://detail.1688.com/offer/40710964384.html"
            var content = WebHttpsUtil.Reponse(url);
            //var content = WebHttpsUtil.Reponse("http://detail.1688.com/offer/41072925730.html");
            //var content = WebHttpsUtil.Reponse("http://detail.1688.com/offer/40843319449.html");
            //var titleMatch = "<h1 class=\"d-title\">[\\s\\S]*</h1>";
            Console.WriteLine("---------Title--------");
            var titleMatch = "<h1 class=\"d-title\">[\\s\\S]*</h1>";
            Console.WriteLine(content.Match(titleMatch));

            var colorMatch = "<dl class=\"J_Prop tb-prop tb-clearfix[\\s\\S]{0,900}</dl>";
            //var colorMatch = "<span class=\"text text-single-line\">[\\s\\S]{0,20}</span>";
            var matches = content.Matches(colorMatch);
            Console.WriteLine("---------Color---------");
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
             
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
            /*
            var entity = repository.SelectItemAll();
            Console.WriteLine("insert into the database finish.");
            IocMapper.Instance.RegistType(Assembly.GetAssembly(typeof(ProductRepository)));
            var rep = IocMapper.Instance.Container.Resolve<IRepository<Product>>();
            */
            Console.ReadLine();
        }
    }
}
