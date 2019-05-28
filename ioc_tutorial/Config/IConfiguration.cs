using ioc_tutorial.Server.Redundancy;

namespace ioc_tutorial.Config
{
    public interface IConfiguration
    {
        string URL { get; set; }
        string Name { get; set; }
        int Port { get; set; }
        string LogFilePath { get; set; }
        ServerRedundancy ServerRedundancy { get; set; }
    }
}
