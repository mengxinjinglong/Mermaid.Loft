using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.Autofac
{
    public class ConsoleLogAdapter:ILogAdapter
    {
        public virtual void Info(string message)
        {
            Console.WriteLine(string.Format("{0}:{1}","Info",message));
        }

        public virtual void Debug(string message)
        {
            Console.WriteLine(string.Format("{0}:{1}", "Debug", message));
        }

        public virtual void Error(string message, Exception e)
        {
            Console.WriteLine(string.Format("{0}:{1}", "Error", message));
        }

        public string Title
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }
    }
}
