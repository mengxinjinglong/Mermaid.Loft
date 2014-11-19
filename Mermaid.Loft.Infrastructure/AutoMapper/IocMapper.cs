using Autofac;
using Mermaid.Loft.Infrastructure.DomainBase;
using Mermaid.Loft.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.AutoMapper
{
    public class IocMapper
    {
        private static readonly IocMapper _instance = new IocMapper();
        private static readonly ContainerBuilder _containerBuilder = new ContainerBuilder();
        private static IContainer _container;
        private IocMapper()
        {
            
        }

        public static IocMapper Instance
        {
            get 
            {
                return _instance;   
            }
        }

        public IContainer Container
        {
            get 
            {
                if (_container == null)
                {
                    lock (this)
                    {
                        if (_container == null)
                        {
                            _container = _containerBuilder.Build();
                        }
                    }
                }
                return _container;
            }
        }
        
        public bool RegistType(Assembly args)
        {
            try
            {
                if (args == null) throw new ArgumentNullException("parameter is null.");
                _containerBuilder.RegisterAssemblyTypes(args)
                    .Where(item => item.Name.EndsWith("Repository")).As<IRepository<EntityBase>>();
                    //.AsImplementedInterfaces();
                return true;
            }
            catch
            {
            }
            return false;
        }

        
    }
}
