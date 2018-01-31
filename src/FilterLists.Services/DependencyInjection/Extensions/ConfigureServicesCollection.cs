using AutoMapper;
using FilterLists.Data;
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
            services.AddEntityFrameworkMySql().AddDbContextPool<FilterListsDbContext>(options =>
                options.UseMySql(configuration.GetConnectionString("FilterListsConnection"),
                    b => b.MigrationsAssembly("FilterLists.Api")));
            services.TryAddScoped<FilterListService.FilterListService>();
            services.TryAddScoped<SeedService.SeedService>();
            services.TryAddScoped<ScrapeService.ScrapeService>();
            services.AddAutoMapper();
        }
    }
}