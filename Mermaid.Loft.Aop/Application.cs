using Autofac;
using Castle.DynamicProxy;
using Autofac.Extras.DynamicProxy2;
using Mermaid.Loft.Infrastructure.Aop.Castle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.Aop
{
    public class Application
    {
        public void Execute()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UserBLL>().As<IUserBLL>().EnableInterfaceInterceptors();
            builder.Register(item => new LogInterceptor());
            builder.Register(item => new Interceptor());
            var container = builder.Build();
            container.Resolve<IUserBLL>().GetUser("hello,aop world.");
            var proxy = new ProxyGenerator();
            var handler = new Interceptor[]{new Interceptor()};
            var userBLL = proxy.CreateClassProxy<UserBLL>(handler);
            userBLL.GetUser("Hello,World.");
        }
    }
}
