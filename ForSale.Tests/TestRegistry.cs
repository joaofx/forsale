using ForSale.Infrastructure;
using StructureMap.Configuration.DSL;

namespace ForSale.Tests
{
    public class TestRegistry : Registry
    {
        public TestRegistry()
        {
            For<ApplicationContext>().Use(() => new ApplicationContext()).Transient();

            For<IDatabaseCleaner>().Use<DatabaseCleaner>();
        }
    }
}