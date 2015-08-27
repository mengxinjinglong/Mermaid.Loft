using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.Aop.Castle
{
    [Serializable]
    public class LogInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("log info,Method:"+invocation.Method.Name);
            try
            {
                invocation.Proceed();
            }
            catch (Exception)
            {
                Console.WriteLine("Target threw an exception!");
                throw;
            }
            finally
            {
                Console.WriteLine("After log info.return value");
            }
        }
    }
}
