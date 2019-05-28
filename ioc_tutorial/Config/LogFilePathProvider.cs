namespace ioc_tutorial.Config
{
    class LogFilePathProvider : ILogFilePathProvider
    {
        private readonly IConfiguration _configuration;

        public LogFilePathProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetLogFilePath()
        {
            return _configuration.LogFilePath;
        }
    }
}
