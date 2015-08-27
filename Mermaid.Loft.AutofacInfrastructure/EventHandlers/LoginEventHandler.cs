
using System;
using Mermaid.Loft.Infrastructure.Autofac.Topics;

namespace Mermaid.Loft.Infrastructure.Autofac.EventHandlers
{
    public class LoginEventHandler:IEventHandler<LoginTopic>
    {
        public void Handle(LoginTopic topic)
        {
            Console.WriteLine("login handle:name:{0},password:{1}"
                ,topic.Name,topic.Password);
        }
    }
}
