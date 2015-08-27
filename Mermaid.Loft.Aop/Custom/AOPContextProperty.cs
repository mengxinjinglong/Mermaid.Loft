using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Mermaid.Loft.Infrastructure.Aop.Custom
{
    public class AOPContextProperty : IContextProperty, IContributeServerContextSink
    {
        public void Freeze(Context newContext)
        {
            
        }

        public bool IsNewContextOK(Context newCtx)
        {
            return true;
        }

        public string Name
        {
            get { return "ContextService"; }
        }
        /// <summary>
        /// 提供的服务
        /// </summary>
        /// <param name="meg"></param>
        public void WriterMessage(string meg)
        {
            Console.WriteLine(meg);
        }

        public IMessageSink GetServerContextSink(IMessageSink nextSink)
        {
            AOPWriterSink megSink = new AOPWriterSink(nextSink);
            return megSink;
        }
    }
}
