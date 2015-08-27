using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.Aop.Custom
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AOPWriterAttribute : Attribute, IContextAttribute
    {
        public void GetPropertiesForNewContext(IConstructionCallMessage msg)
        {
            msg.ContextProperties.Add(new AOPContextProperty());

        }

        public bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, IConstructionCallMessage msg)
        {
            return false;
        }
    }
}
