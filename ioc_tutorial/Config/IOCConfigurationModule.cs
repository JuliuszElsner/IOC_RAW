using Autofac;

namespace ioc_tutorial.Config
{
    public class IOCConfigurationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConfigurationReader>().AsImplementedInterfaces();
            builder.RegisterType<LogFilePathProvider>().AsImplementedInterfaces();
            builder.Register(
                ctx =>
                {
                    var reader = ctx.Resolve<IConfigurationReader>();
                    return reader.Read();
                }).AsImplementedInterfaces();
        }
    }
}
