using System.Threading;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace FilterLists.Data.Tests
{
    public class SeedFilterListsDbContextTests
    {
        [Fact]
        public void Migrate_DoesNotThrowException()
        {
            // TODO: replace with Polly or similar to optimize time waste
            // allow time for db to init
            Thread.Sleep(20000);

            const string connString = "Server=mariadb;Database=filterlists;Uid=filterlists;Pwd=filterlists;";
            var options = new DbContextOptionsBuilder<FilterListsDbContext>().UseMySql(connString,
                    m => m.MigrationsAssembly("FilterLists.Data.Migrations").ServerVersion(Constants.ServerVersion))
                .EnableSensitiveDataLogging().Options;

            using var context = new FilterListsDbContext(options);
            context.Database.Migrate();
        }
    }
}