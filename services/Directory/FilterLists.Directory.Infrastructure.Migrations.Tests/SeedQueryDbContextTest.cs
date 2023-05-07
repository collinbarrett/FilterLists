using FilterLists.Directory.Infrastructure.Migrations.Migrations;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace FilterLists.Directory.Infrastructure.Migrations.Tests;

public class SeedQueryDbContextTest
{
    [Fact]
    public async Task Migrate_DoesNotThrowException()
    {
        var exception = await Record.ExceptionAsync(async () =>
        {
            var connString = Environment.GetEnvironmentVariable("ConnectionStrings__DirectoryConnection") ??
                             throw new Exception();
            var options = new DbContextOptionsBuilder<QueryDbContext>()
                .UseNpgsql(connString, m => m.MigrationsAssembly(typeof(InitialCreate).Assembly.GetName().Name))
                .EnableSensitiveDataLogging()
                .Options;
            await using var context = new QueryDbContext(options);
            await context.Database.MigrateAsync();
        });
        Assert.Null(exception);
    }
}
