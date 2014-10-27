using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mermaid.Loft.Infrastructure.Regular;
using Mermaid.Loft.Infrastructure.WebHttps;

namespace Mermaid.Loft.ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = "---zsd123@sdh@周升东.com===000";
            foreach (var item in source.Matches(@"\w@"))
                Console.WriteLine("the result is :" + item);

            var content = WebHttpsUtil.Reponse("http://www.baidu.com");
            Console.WriteLine(content.Match(@"<input\sid="));
            Console.ReadLine();
        }
    }
}
