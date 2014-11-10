using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.AutoMapper
{
    public class IocMapper
    {
        private static readonly IocMapper _instance = new IocMapper();
        private static readonly ContainerBuilder _containerBuilder = new ContainerBuilder();

        private IocMapper()
        {
            
        }

        public bool RegistType(Type type, Type asType = null)
        {
            if (asType == null)
            { 
                //_containerBuilder.RegisterType<type>();
            }
            return false;
        }
    }
}
