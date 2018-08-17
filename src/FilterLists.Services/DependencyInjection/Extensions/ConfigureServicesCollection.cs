using AutoMapper;
using FilterLists.Data;
using FilterLists.Services.FilterList;
using FilterLists.Services.Seed;
using FilterLists.Services.Snapshot;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace FilterLists.Services.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        public static void AddFilterListsApiServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton(c => config);
            services.AddEntityFrameworkMySql()
                    .AddDbContextPool<FilterListsDbContext>(o =>
                        o.UseMySql(config.GetConnectionString("FilterListsConnection"),
                            m => m.MigrationsAssembly("FilterLists.Api")));
            services.TryAddScoped<FilterListService>();
            services.TryAddScoped<RuleService>();
            services.TryAddScoped<SeedService>();
            services.AddAutoMapper();
        }

        public static void AddFilterListsAgentServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton(c => config);
            services.AddEntityFrameworkMySql()
                    .AddDbContextPool<FilterListsDbContext>(o =>
                        o.UseMySql(config.GetConnectionString("FilterListsConnection"),
                            m => m.MigrationsAssembly("FilterLists.Api")));
            services.TryAddScoped<SnapshotService>();
            services.TryAddScoped<EmailService>();
            services.AddAutoMapper();
        }
    }
}