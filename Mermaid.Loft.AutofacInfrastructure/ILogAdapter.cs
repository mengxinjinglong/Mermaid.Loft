using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.Autofac
{
    public interface ILogAdapter
    {
        string Title { get; set; }
        string Description { get; set; }
        void Info(string message);
        void Debug(string message);
        void Error(string message, Exception e);
    }
}
