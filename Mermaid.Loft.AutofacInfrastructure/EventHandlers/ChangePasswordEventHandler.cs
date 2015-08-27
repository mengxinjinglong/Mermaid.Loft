
using System;
using Mermaid.Loft.Infrastructure.Autofac.Topics;

namespace Mermaid.Loft.Infrastructure.Autofac.EventHandlers
{
    public class ChangePasswordEventHandler:IEventHandler<ChangePasswordTopic>
    {
        public void Handle(ChangePasswordTopic topic)
        {
            Console.WriteLine("change password handle:name:{0},password:{1},confirm password:{2}"
                , topic.Name, topic.Password,topic.ConfirmPassword);
        }
    }
}
