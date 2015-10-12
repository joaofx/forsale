using System.Data.Entity.Migrations;
using ForSale.Infrastructure;

namespace ForSale.Tests
{
    public class MigrationConfiguration : DbMigrationsConfiguration<ApplicationContext>
    {
        public MigrationConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}