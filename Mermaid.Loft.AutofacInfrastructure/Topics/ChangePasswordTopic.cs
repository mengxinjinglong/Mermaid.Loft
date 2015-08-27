
namespace Mermaid.Loft.Infrastructure.Autofac.Topics
{
    public class ChangePasswordTopic:BaseTopic
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
