using System.Data.Entity.Migrations;

namespace ForSale.Tests
{
    public class DatabaseMigration
    {
        public static void Update()
        {
            var configuration = new MigrationConfiguration();
            var migrator = new DbMigrator(configuration);
            migrator.Update();
        }
    }
}