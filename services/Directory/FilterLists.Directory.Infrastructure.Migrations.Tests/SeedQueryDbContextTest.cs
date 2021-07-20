using System;
using FilterLists.Directory.Infrastructure.Migrations.Migrations;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace FilterLists.Directory.Infrastructure.Migrations.Tests
{
    public class SeedQueryDbContextTest
    {
        [Fact]
        public void Migrate_DoesNotThrowException()
        {
            var exception = Record.Exception(() =>
            {
                var connString = Environment.GetEnvironmentVariable("ConnectionStrings__DirectoryConnection") ??
                                 throw new Exception();
                var options = new DbContextOptionsBuilder<QueryDbContext>()
                    .UseNpgsql(connString, m => m.MigrationsAssembly(typeof(Initial).Assembly.GetName().Name))
                    .EnableSensitiveDataLogging()
                    .Options;
                using var context = new QueryDbContext(options);
                context.Database.Migrate();
            });
            Assert.Null(exception);
        }
    }
}
