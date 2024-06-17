using FilterLists.Directory.Infrastructure.Persistence.Queries;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Directory.Infrastructure;

public static class ConfigurationExtensions
{
    private const string MigrationsAssembly = "FilterLists.Directory.Infrastructure.Migrations";

    public static void AddInfrastructure(this IHostApplicationBuilder builder)
    {
        // TODO: use different connection strings for migrations and queries (https://stackoverflow.com/q/78564037/2343739)
        builder.AddSqlServerDbContext<QueryDbContext>("directorydb",
            _ => { },
            o => o.UseSqlServer(so =>
                    // retry on Microsoft.Data.SqlClient.SqlException (0x80131904): A connection was successfully established with the server, but then an error occurred during the pre-login handshake. (provider: TCP Provider, error: 0 - Undefined error: 0)
                    so.EnableRetryOnFailure([0])
                        .MigrationsAssembly(MigrationsAssembly))
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .EnableSensitiveDataLogging(string.Equals(
                    Environment.GetEnvironmentVariable("DOTNET_RUNNING_EF_CORE_TOOLS"), "true",
                    StringComparison.OrdinalIgnoreCase)));
        builder.Services.AddHostedService<MigrationService>();
        builder.Services.AddMemoryCache();
    }
}