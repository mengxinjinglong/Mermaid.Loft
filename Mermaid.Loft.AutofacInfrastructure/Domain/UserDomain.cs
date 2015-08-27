
using Mermaid.Loft.Infrastructure.Autofac.Topics;

namespace Mermaid.Loft.Infrastructure.Autofac.Domain
{
    public class UserDomain
    {
        public UserDomain()
        {
        }

        public void Login(string name,string password)
        {
            MermaidEventBus.Instance.Publish(new LoginTopic {Name = name,Password = password});
        }
        public void ChangePassword(string name, string password,string confirmPassword)
        {
            MermaidEventBus.Instance.Publish(new ChangePasswordTopic { Name = name, Password = password, ConfirmPassword = confirmPassword });
        }
    }
}
