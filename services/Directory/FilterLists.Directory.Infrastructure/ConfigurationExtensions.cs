using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.SharedKernel.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Directory.Infrastructure;

public static class ConfigurationExtensions
{
    public static IHostBuilder UseInfrastructure(this IHostBuilder hostBuilder)
    {
        return hostBuilder.UseLogging();
    }

    public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSharedKernelLogging(configuration);
        services.AddDbContextPool<QueryDbContext>(o =>
        {
            o.UseNpgsql(configuration.GetConnectionString("DirectoryConnection"),
                po => po.MigrationsAssembly("FilterLists.Directory.Infrastructure.Migrations"));
        });
        services.AddScoped<IQueryContext, QueryContext>();
    }

    public static void UseInfrastructure(this IApplicationBuilder app)
    {
        app.UseLogging();
    }
}
