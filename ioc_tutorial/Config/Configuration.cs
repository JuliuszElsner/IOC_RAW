using ioc_tutorial.Server.Redundancy;

namespace ioc_tutorial.Config
{
    public class Configuration : IConfiguration
    {
        public string URL { get; set; }
        public string Name { get; set; }
        public int Port { get; set; }
        public string LogFilePath { get; set; } = "D:\\temp\\log.txt";
        public ServerRedundancy ServerRedundancy { get; set; }
    }
}
