using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Api.Persistence.Extensions;

internal static class ConfigurationExtensions
{
    internal static IHostBuilder AddEntityFrameworkCore(this IHostBuilder hostBuilder)
    {
        const string connectionStringKey = "FilterListsReadOnlyConnectionString";
        var connectionString = Environment.GetEnvironmentVariable(connectionStringKey) ??
                               throw new InvalidOperationException($"Missing {connectionStringKey}");
        hostBuilder.ConfigureServices(services =>
            services.AddDbContext<FilterListsDbContext>(options =>
                options.UseSqlServer(connectionString)
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)));
        return hostBuilder;
    }
}