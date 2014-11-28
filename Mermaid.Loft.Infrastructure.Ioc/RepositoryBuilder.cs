using Autofac;
using Mermaid.Loft.Infrastructure.Ioc.Categories;
using Mermaid.Loft.Infrastructure.Ioc.Products;
using Mermaid.Loft.Infrastructure.Ioc.Users;
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
        private static readonly ContainerBuilder _containerBuilder = new ContainerBuilder();

        private static IContainer _container  = null;
        private RepositoryBuilder() { }

        public static RepositoryBuilder Instance { 
            get { return _instance; } 
        }

        public void RegisterType<T>() where T:class
        {
            _containerBuilder.RegisterType<T>();
        }

        public T GetInstance<T>() where T:class
        { 
            return _container.Resolve<T>();
        }

        public void Initialize()
        {
            _containerBuilder.RegisterType<CategoryRepositoryImpl>()
                .As<ICategoryRepository>();
            _containerBuilder.RegisterType<ProductRepositoryImpl>()
                .As<IProductRepository>();
            _containerBuilder.RegisterType<UserRepositoryImpl>()
                .As<IUserRepository>();

            _container = _containerBuilder.Build();
        }
    }
}
