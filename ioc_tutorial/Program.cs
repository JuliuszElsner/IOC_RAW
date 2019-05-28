using Autofac;
using DatabaseLib.UsersStorage;
using ioc_tutorial.Config;
using ioc_tutorial.IOC;
using ioc_tutorial.Logging;
using ioc_tutorial.Server;
using ioc_tutorial.Server.Redundancy;
using System.Threading;
using System.Threading.Tasks;

namespace ioc_tutorial
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            Container = ContainerProvider.GetContainer();

            var serverSwitcher = Container.Resolve<IServerSwitcher>();

            while (true)
            {
                serverSwitcher.ProcessingLoop();
                Thread.Sleep(2000);
            }
        }
    }
}
