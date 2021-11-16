using FilterLists.Directory.Infrastructure.Persistence.Commands.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.SharedKernel.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
#if DEBUG
using Microsoft.Extensions.Logging;
#endif

namespace FilterLists.Directory.Infrastructure;

public static class ConfigurationExtensions
{
    public static IHostBuilder ConfigureInfrastructure(this IHostBuilder hostBuilder)
    {
        return hostBuilder.ConfigureLogging();
    }

    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSharedKernelLogging(configuration);
        services.AddDbContextPool<QueryDbContext>(o =>
        {
            o.UseNpgsql(configuration.GetConnectionString("DirectoryConnection"),
                    po => po.MigrationsAssembly("FilterLists.Directory.Infrastructure.Migrations"))
                .UseSnakeCaseNamingConvention()
#if DEBUG
                .LogTo(Console.WriteLine, LogLevel.Information);
            o.EnableSensitiveDataLogging();
#else
                ;
#endif
        });
        services.AddDbContextPool<CommandDbContext>(o =>
        {
            o.UseNpgsql(configuration.GetConnectionString("DirectoryConnection"))
                .UseSnakeCaseNamingConvention()
#if DEBUG
                .LogTo(Console.WriteLine, LogLevel.Information);
            o.EnableSensitiveDataLogging();
#else
                ;
#endif
        });
        services.AddScoped<IQueryContext, QueryContext>();
        services.AddScoped<ICommandContext, CommandDbContext>();
    }

    public static void UseInfrastructure(this IApplicationBuilder app)
    {
        app.UseLogging();
    }
}
