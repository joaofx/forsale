using System.Configuration;

namespace ForSale.Tests
{
    public class DatabaseConfiguration
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["ApplicationContext"].ConnectionString;
    }
}