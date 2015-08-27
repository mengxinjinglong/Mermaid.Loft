using Autofac.Extras.DynamicProxy2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.Aop.Castle
{
    public interface IUserBLL
    {
        void GetUser(string userName);
    }
    [Intercept(typeof(LogInterceptor))]
    [Intercept(typeof(Interceptor))]
    public class UserBLL : IUserBLL
    {
        public virtual void GetUser(string userName)
        {
            Console.WriteLine(userName + ",GSpring");
        }
    }
}
