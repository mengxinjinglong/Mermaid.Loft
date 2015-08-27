using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.Aop.Custom
{
    [AOPWriter]
    public class MyContextObject : ContextBoundObject
    {
        public void WriteLine(string message)
        {
            Console.WriteLine("this is execute message:"+message);
        }
    }
}
