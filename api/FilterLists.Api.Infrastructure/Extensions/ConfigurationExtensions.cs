using FilterLists.Api.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Api.Infrastructure.Extensions;

public static class ConfigurationExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, string readOnlyConnectionString)
    {
        services.AddDbContext<FilterListsDbContext>(options =>
            options.UseSqlServer(readOnlyConnectionString,
                    b =>
                    {
                        // TODO: rm separate console app since isolated az func _should_ support EF Core migrations
                        b.MigrationsAssembly("FilterLists.Api.Infrastructure.Migrations");
                        b.EnableRetryOnFailure(
                            10,
                            TimeSpan.FromSeconds(30),
                            null);
                    })
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
    }
}