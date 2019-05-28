using ioc_tutorial.Logging.Writers;

namespace ioc_tutorial.Server
{
    public interface ILogServerFactory
    {
        IServer Create(LoggingType loggingType);
    }
}
