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
        public static void AddFilterListsServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(c => configuration);
            services.AddEntityFrameworkMySql()
                    .AddDbContextPool<FilterListsDbContext>(options =>
                        options.UseMySql(configuration.GetConnectionString("FilterListsConnection"),
                                   b => b.MigrationsAssembly("FilterLists.Api"))
                               .EnableSensitiveDataLogging());
            services.TryAddScoped<FilterListService>();
            services.TryAddScoped<SeedService>();
            services.TryAddScoped<SnapshotService>();
            services.AddAutoMapper();
        }
    }
}