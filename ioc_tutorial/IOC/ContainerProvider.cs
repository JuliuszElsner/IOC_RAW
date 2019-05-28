using Autofac;
using ioc_tutorial.Config;
using ioc_tutorial.Logging.Writers;
using ioc_tutorial.Server;
using ioc_tutorial.Server.Redundancy;
using System.Linq;
using System.Reflection;

namespace ioc_tutorial.IOC
{
    public static class ContainerProvider
    {
        private static readonly ContainerBuilder _builder;

        static ContainerProvider()
        {
            _builder = new ContainerBuilder();
            _builder.RegisterAssemblyTypes(Assembly.Load(nameof(DatabaseLib)))
                .Where(t => t.Namespace.Contains("UsersStorage") && t.GetInterfaces().FirstOrDefault(i => i.Name == $"I{t.Name}") != null)
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == $"I{t.Name}"));

            _builder.RegisterModule<IOCServerModule>();
            _builder.RegisterModule<IOCLoggingModule>();
            _builder.RegisterModule<IOCConfigurationModule>();
            _builder.RegisterModule<IOCRedundancyModule>();
            _builder.RegisterModule<IOCServerModule>();
        }

        public static IContainer GetContainer()
        {
            return _builder.Build();
        }
    }
}
