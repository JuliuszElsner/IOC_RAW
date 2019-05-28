using Autofac.Features.Indexed;
using DatabaseLib.UsersStorage;
using ioc_tutorial.Logging;
using ioc_tutorial.Logging.Writers;

namespace ioc_tutorial.Server
{
    public class LogServerFactory : ILogServerFactory
    {
        private readonly IIndex<LoggingType, ILogWriter> _logWriters;
        private readonly IUserPreferences _userPreferences;
        private readonly IUsers _usersSource;

        public LogServerFactory(IIndex<LoggingType, ILogWriter> logWriters, IUsers usersSource, IUserPreferences userPreferences)
        {
            _logWriters = logWriters;
            _usersSource = usersSource;
            _userPreferences = userPreferences;
    }

        public IServer Create(LoggingType loggingType)
        {
            return new LogServer(_logWriters[loggingType], _usersSource, _userPreferences);
        }
    }
}
