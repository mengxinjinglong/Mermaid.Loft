using Mermaid.Loft.Infrastructure.Autofac.Topics;

namespace Mermaid.Loft.Infrastructure.Autofac.EventHandlers
{
    public interface IEventHandler<T> where T:BaseTopic 
    {
        void Handle(T topic);
    }
}
