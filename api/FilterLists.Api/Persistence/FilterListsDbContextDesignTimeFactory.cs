using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FilterLists.Api.Persistence;

// ReSharper disable once UnusedType.Global
internal class FilterListsDbContextDesignTimeFactory : IDesignTimeDbContextFactory<FilterListsDbContext>
{
    public FilterListsDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("local.settings.json")
            .Build();
        const string connectionStringKey = "FilterListsDdladminConnectionString";
        var connectionString = Environment.GetEnvironmentVariable(connectionStringKey) ??
                               configuration.GetSection("values").GetValue<string>(connectionStringKey) ??
                               throw new InvalidOperationException($"Missing {connectionStringKey}");
        var optionsBuilder = new DbContextOptionsBuilder<FilterListsDbContext>();
        optionsBuilder.UseSqlServer(connectionString);
        return new FilterListsDbContext(optionsBuilder.Options);
    }
}