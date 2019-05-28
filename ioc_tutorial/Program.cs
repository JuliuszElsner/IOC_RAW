using DatabaseLib.UsersStorage;
using ioc_tutorial.Config;
using ioc_tutorial.Logging;
using ioc_tutorial.Server;
using ioc_tutorial.Server.Redundancy;
using System.Threading;
using System.Threading.Tasks;

namespace ioc_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationReader().Read();
            var logWriter = new LogWriter(configuration.LogFilePath);
            //var extendedLogWriter = new ExtendedLogWriter(configuration.LogFilePath);
            var logWriterWithWeb = new LogWebWriter(logWriter);

            var users = new Users();
            var userPreferences = new UserPreferences();

            var server_1 = new LogServer(logWriter, users, userPreferences);
            var server_2 = new LogServer(logWriterWithWeb, users, userPreferences);
            var server_3 = new LogServer(logWriter, users, userPreferences);

            var serverSwitcher = new ServerSwitcher(configuration.ServerRedundancy)
            {
                PrimaryServer = server_1,
                SecondaryServer = server_2,
                TertiaryServer = server_3
            };

            while (true)
            {
                serverSwitcher.ProcessingLoop();
                Thread.Sleep(2000);
            }
        }
    }
}
