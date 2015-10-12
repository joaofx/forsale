using System;
using StructureMap;
using StructureMap.Graph;

namespace ForSale.Tests
{
    public static class IoC
    {
        public static IContainer Container;

        public static IContainer ParentScope { get; set; }

        public static Container Initialize(Action<ConfigurationExpression> callerContainerConfiguration = null)
        {
            return new Container(c =>
            {
                c.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.LookForRegistries();
                });

                callerContainerConfiguration?.Invoke(c);
            });
        }
    }
}