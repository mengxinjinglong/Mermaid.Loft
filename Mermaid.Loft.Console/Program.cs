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
        public static IList<Product> ProductList
        {
            get 
            {
                var dictionary = new Dictionary<string,UrlMapper>();
                //1
                dictionary.Add("2014秋冬时尚 百搭女装无袖棉衣马甲背心棉马甲", new UrlMapper { 
                    Url = "http://item.taobao.com/item.htm?spm=a1z10.3.w4002-5862495901.24.5neRUh&id=42271148128",
                    SourceUrl = "http://detail.1688.com/offer/41429883359.html"
                });
                //2
                dictionary.Add("2014新款韩版森女假两件长袖V领修身时尚针织包臀连衣裙秋季女装", new UrlMapper {
                    Url = "http://item.taobao.com/item.htm?spm=a1z10.3.w4002-5862495901.27.5neRUh&id=42206395095",
                    SourceUrl = "http://detail.1688.com/offer/40807419640.html"
                });
                //3
                dictionary.Add("爆新品 2014秋冬装新款毛呢大衣 韩版修身大码中长款呢外套", new UrlMapper {
                    Url = "http://item.taobao.com/item.htm?spm=a1z10.3.w4002-5862495901.30.5neRUh&id=42205375976",
                    SourceUrl = "http://detail.1688.com/offer/41808680401.html"
                });
                //4
                dictionary.Add("2014秋季新款女装韩版时尚修身优雅长袖一粒扣西装领中长款西装", new UrlMapper {
                    Url = "http://item.taobao.com/item.htm?spm=a1z10.3.w4002-5862495901.33.5neRUh&id=42269496228",
                    SourceUrl = "http://detail.1688.com/offer/40809326915.html"
                });
                //5
                dictionary.Add("爆新品 2014冬季呢子衣女双排扣中长款韩版修身毛呢大衣外套", new UrlMapper {
                    Url = "http://item.taobao.com/item.htm?spm=a1z10.3.w4002-5862495901.39.5neRUh&id=42051839875",
                    SourceUrl = "http://detail.1688.com/offer/41767902142.html"
                });
                //6
                dictionary.Add("2014秋新女装韩版时尚甜美百搭莫代尔长袖雪纺衫上衣", new UrlMapper {
                    Url = "http://item.taobao.com/item.htm?spm=a1z10.3.w4002-5862495901.42.5neRUh&id=41199575353",
                    SourceUrl = "http://detail.1688.com/offer/40492655001.html"
                });
                
                var list = new List<Product>();
                foreach(var item in dictionary)
                {
                    list.Add(new Product {
                        ProductId = Guid.NewGuid().ToString(),
                        ProductName = item.Key,
                        UserId = "mengxinjinglong",
                        Categories = "",
                        Url = item.Value.Url,
                        SourceUrl = item.Value.SourceUrl,
                        Description = "",
                        CreateDate = DateTime.Now.ToLocalTime(),
                        UpdateDate = DateTime.Now.ToLocalTime()
                    });
                }
                return list;            
            }
        }
        static void Main(string[] args)
        {

           IRepository<Product> repository = new ProductRepository();
            
            var entity = repository.SelectItemAll();
            /*
            Console.WriteLine("insert into the database finish.");
            IocMapper.Instance.RegistType(Assembly.GetAssembly(typeof(ProductRepository)));
            var rep = IocMapper.Instance.Container.Resolve<IRepository<Product>>();
            */
            Console.ReadLine();
        }
    }

    class ReglarRule
    {
        public const string RULE = "<dl class=\"J_Prop tb-prop tb-clearfix[\\s\\S]{0,900}</dl>";
        public const string SOURCE_RULE = "<span class=\"text text-single-line\">[\\s\\S]{0,20}</span>";
    }

    class UrlMapper
    {
        public string Url;
        public string SourceUrl;
    }
}
