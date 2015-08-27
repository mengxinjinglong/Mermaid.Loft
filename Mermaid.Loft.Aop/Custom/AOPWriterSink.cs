using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;

namespace Mermaid.Loft.Infrastructure.Aop.Custom
{
    public class AOPWriterSink : IMessageSink
    {
        private IMessageSink m_NextSink;
        public AOPWriterSink(IMessageSink nextSink)
        {
            m_NextSink = nextSink;
        }

        public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
        {
            return null;
        }

        public IMessageSink NextSink
        {
            get { return m_NextSink; }
        }

        public IMessage SyncProcessMessage(IMessage msg)
        {


            IMethodCallMessage callMessage = msg as IMethodCallMessage;
            if (callMessage.MethodName == "WriteLine")
            {
                Context context = Thread.CurrentContext;
                AOPContextProperty contextWriterService =
                    context.GetProperty("ContextService") as AOPContextProperty;
                if (callMessage == null)
                {
                    return null;
                }
                IMessage retMsg = null;
                if (contextWriterService != null)
                {
                    contextWriterService.WriterMessage("方法调用之前");
                }
                retMsg = m_NextSink.SyncProcessMessage(msg);
                contextWriterService.WriterMessage("方法调用之后");
                return retMsg;
            }
            else
            {
                return m_NextSink.SyncProcessMessage(msg);
            }
        }
    }
}
