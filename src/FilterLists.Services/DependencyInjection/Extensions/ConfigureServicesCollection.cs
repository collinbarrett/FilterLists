using AutoMapper;
using FilterLists.Data;
using FilterLists.Services.FilterList;
using FilterLists.Services.Language;
using FilterLists.Services.List;
using FilterLists.Services.Seed;
using FilterLists.Services.Snapshot;
using FilterLists.Services.Software;
using FilterLists.Services.Tag;
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
            services.TryAddScoped<ListService>();
            services.TryAddScoped<LanguageService>();
            services.TryAddScoped<SeedService>();
            services.TryAddScoped<SoftwareService>();
            services.TryAddScoped<TagService>();
            services.TryAddScoped<RuleService>();
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
            services.TryAddScoped<Logger>();
            services.AddAutoMapper();
        }
    }
}