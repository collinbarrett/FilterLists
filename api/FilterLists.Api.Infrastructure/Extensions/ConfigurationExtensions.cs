using FilterLists.Api.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Api.Infrastructure.Extensions;

public static class ConfigurationExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, string readOnlyConnectionString)
    {
        services.AddDbContext<QueryDbContext>(options => options.UseSqlServer(readOnlyConnectionString,
            b => b.MigrationsAssembly("FilterLists.Api.Infrastructure.Migrations")));
        services.AddScoped<IQueryContext, QueryContext>();
    }
}