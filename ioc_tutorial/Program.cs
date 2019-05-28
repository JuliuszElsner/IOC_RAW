using ioc_tutorial.Config;
using ioc_tutorial.Logging;
using ioc_tutorial.Server;
using ioc_tutorial.Server.Redundancy;
using System.Threading.Tasks;

namespace ioc_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationReader().Read();
            var logWriter = new LogWriter(configuration.LogFilePath);
            var extendedLogWriter = new ExtendedLogWriter(configuration.LogFilePath);
            var logWriterWithWeb = new LogWebWriter(logWriter);

            var server_1 = new LogServer(logWriter);
            var server_2 = new LogServer(logWriterWithWeb);
            var server_3 = new LogServer(extendedLogWriter);

            var serverSwitcher = new ServerSwitcher(configuration.ServerRedundancy)
            {
                PrimaryServer = server_1,
                SecondaryServer = server_2,
                TertiaryServer = server_3
            };

            while (true)
            {
                Task.Delay(1000);
            }
        }
    }
}
