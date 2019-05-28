using Autofac;

namespace ioc_tutorial.IOC
{
    public static class ContainerProvider
    {
        private static readonly ContainerBuilder _builder = new ContainerBuilder();

        static ContainerProvider()
        {
            _builder.RegisterAssemblyTypes(Assembly.Load)
        }

        public static IContainer GetContainer()
        {
            return _builder.Build();
        }
    }
}
