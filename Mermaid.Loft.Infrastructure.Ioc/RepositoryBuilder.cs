using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.Ioc
{
    public class RepositoryBuilder : IRepositoryBuilder
    {
        private static readonly RepositoryBuilder _instance = new RepositoryBuilder();
        private static readonly ContainerBuilder _container = new ContainerBuilder();
        private RepositoryBuilder() { }

        public static RepositoryBuilder Instance { 
            get { return _instance; } 
        }

        public void RegisterType<T>() where T:class
        {
            _container.RegisterType<T>();
        }
    }
}
