using Autofac;
using ioc_tutorial.Config;

namespace ioc_tutorial.Logging.Writers
{
    public class IOCLoggingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register<LogWriter>(
                ctx =>
                {
                    var configuration = ctx.Resolve<IConfiguration>();
                    return new LogWriter(configuration.LogFilePath);
                }).Keyed<ILogWriter>(LoggingType.LogBasic);

            builder.RegisterType<ExtendedLogWriter>().Keyed<ILogWriter>(LoggingType.LogExtended);

            builder.RegisterDecorator<LogLocalWriter, ILogWriter>();
            builder.RegisterDecorator<ILogWriter>((ctx, inner) => new LogWebWriter(inner), fromKey: LoggingType.LogExtended, toKey: LoggingType.LogExtendedWithWeb);
        }
    }
}
