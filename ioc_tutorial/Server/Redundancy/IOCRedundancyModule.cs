using Autofac;
using ioc_tutorial.Config;
using ioc_tutorial.Logging.Writers;

namespace ioc_tutorial.Server.Redundancy
{
    public class IOCRedundancyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register<ServerRedundancy>(
                ctx =>
                {
                    var configuration = ctx.Resolve<IConfiguration>();
                    return configuration.ServerRedundancy;
                }).AsSelf();

            builder.RegisterType<ServerSwitcher>().AsImplementedInterfaces()
                .OnActivating(
                    ss =>
                    {
                        ss.Instance.PrimaryServer = ss.Context.Resolve<IServer>();
                        ss.Instance.SecondaryServer = ss.Context.Resolve<IServer>();
                        ss.Instance.TertiaryServer = ss.Context.Resolve<ILogServerFactory>().Create(LoggingType.LogBasic);
                    });
        }
    }
}
