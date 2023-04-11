using FilterLists.Api.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Api.Infrastructure.Extensions;

public static class ConfigurationExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, string readOnlyConnectionString)
    {
        services.AddDbContext<QueryDbContext>(options =>
            options.UseSqlServer(readOnlyConnectionString,
                    b =>
                    {
                        b.MigrationsAssembly("FilterLists.Api.Infrastructure.Migrations");
                        b.EnableRetryOnFailure(
                            10,
                            TimeSpan.FromSeconds(30),
                            null);
                    })
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
        services.AddScoped<IQueryContext, QueryContext>();
    }
}