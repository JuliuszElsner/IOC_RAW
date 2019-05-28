using Autofac;
using Autofac.Features.AttributeFilters;

namespace ioc_tutorial.Server
{
    public class IOCServerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LogServer>().AsImplementedInterfaces().WithAttributeFiltering();
            builder.RegisterType<LogServerFactory>().AsImplementedInterfaces();
        }
    }
}
