using FilterLists.Directory.Infrastructure.Persistence.Queries;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Directory.Infrastructure;

public static class ConfigurationExtensions
{
    private const string MigrationsAssembly = "FilterLists.Directory.Infrastructure.Migrations";

    public static void AddInfrastructure(this IHostApplicationBuilder builder)
    {
        // Get connection string from configuration
        var connectionString = builder.Configuration.GetConnectionString("directorydb")
            ?? throw new InvalidOperationException("Connection string 'directorydb' not found.");

        // Register DbContext with standard EF Core configuration
        builder.Services.AddDbContext<QueryDbContext>(options =>
        {
            options.UseSqlServer(connectionString, sqlServerOptions =>
            {
                // retry on Microsoft.Data.SqlClient.SqlException (0x80131904): A connection was successfully established with the server, but then an error occurred during the pre-login handshake. (provider: TCP Provider, error: 0 - Undefined error: 0)
                sqlServerOptions.EnableRetryOnFailure(errorNumbersToAdd: [0]);
                sqlServerOptions.MigrationsAssembly(MigrationsAssembly);
            });
            
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            options.EnableSensitiveDataLogging(string.Equals(
                Environment.GetEnvironmentVariable("DOTNET_RUNNING_EF_CORE_TOOLS"), "true",
                StringComparison.OrdinalIgnoreCase));
        });

        builder.Services.AddHostedService<MigrationService>();
    }
}