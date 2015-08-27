
using System;
using System.Collections.Generic;
using System.Reflection;
using Autofac;
using Mermaid.Loft.Infrastructure.Autofac.EventHandlers;
using Mermaid.Loft.Infrastructure.Autofac.Topics;

namespace Mermaid.Loft.Infrastructure.Autofac
{
    public class MermaidEventBus
    {
        public static MermaidEventBus Instance { get; private set; }
        private static IContainer _container;

        public static MermaidEventBus Create()
        {
            _container = _container ?? (new ContainerBuilder().Build());
            return Instance ?? (Instance = new MermaidEventBus());
        }

        public MermaidEventBus LoadAssembly(string assemblyName)
        {
            var builder = new ContainerBuilder();
            var assembly = Assembly.Load(assemblyName);
            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.EndsWith("EventHandler"))
                .AsImplementedInterfaces();
            builder.Update(_container);
            return this;
        }

        public void Publish<T>(T topic) where T:BaseTopic
        {
            try
            {
                var handlers = _container.Resolve<IEnumerable<IEventHandler<T>>>();
                foreach (var handle in handlers)
                {
                    try
                    {
                        handle.Handle(topic);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(handle.GetType().Name + "执行失败," + e.Message);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(typeof(T).Name + "事件执行失败"+e.Message);
            }
        }
    }
}
