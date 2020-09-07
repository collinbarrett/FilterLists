using System.Threading;
using System.Threading.Tasks;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace FilterLists.Directory.Infrastructure.Migrations.Tests
{
    public class SeedQueryDbContextTest
    {
        [Fact]
        public async Task Migrate_DoesNotThrowException()
        {
            var exception = await Record.ExceptionAsync(async () =>
            {
                // allow time for db to init
                Thread.Sleep(5000);

                const string connString = "Server=directory-db;Database=filterlists;Uid=filterlists;Pwd=filterlists;";
                var options = new DbContextOptionsBuilder<QueryDbContext>()
                    .UseNpgsql(connString, m => m.MigrationsAssembly("FilterLists.Directory.Infrastructure.Migrations"))
                    .EnableSensitiveDataLogging()
                    .Options;

                await using var context = new QueryDbContext(options);
                await context.Database.MigrateAsync();
            });
            Assert.Null(exception);
        }
    }
}