using Autofac;
using Mermaid.Loft.Infrastructure.Autofac.Domain;

namespace Mermaid.Loft.Infrastructure.Autofac
{
    public class Application
    {
        public void ExecuteEventBus()
        {
            MermaidEventBus.Create()
                .LoadAssembly("Mermaid.Loft.Infrastructure.Autofac");
            var userDomain = new UserDomain();
            userDomain.Login("zhousd", "123qweasdzxc");
            userDomain.ChangePassword("zhousd", "123qweasdzxc","1qaz2wsx3edc");
        }

        public void Execute()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleLogAdapter>().As<ILogAdapter>();//.SingleInstance();
            
            var container = builder.Build();
            var logAdapter = container.Resolve<ILogAdapter>();
            logAdapter.Title = "Console Log";
            logAdapter.Description = "this is a light console log sample.";
            logAdapter.Info(logAdapter.Title);
            var log = container.Resolve<ILogAdapter>();
            log.Info(log.Description);
            log.Debug((log == logAdapter).ToString());
        }
    }
}
