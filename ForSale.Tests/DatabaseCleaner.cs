using ForSale.Tests.Features.Product;
using Respawn;

namespace ForSale.Tests
{
    public class DatabaseCleaner : IDatabaseCleaner
    {
        private static readonly Checkpoint Checkpoint = new Checkpoint
        {
            TablesToIgnore = new[]
            {
                "sysdiagrams",
                "tblUser",
                "tblObjectType",
                "__MigrationHistory"
            },
            SchemasToExclude = new string[] { }
        };

        public void Clean()
        {
            Checkpoint.Reset(DatabaseConfiguration.ConnectionString);
        }
    }
}