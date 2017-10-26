using FilterLists.Data.Contexts;
using FilterLists.Data.Repositories.Contracts;
using FilterLists.Data.Repositories.Implementations;
using FilterLists.Services.Contracts;
using FilterLists.Services.Implementations;
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
            services.AddEntityFrameworkMySql().AddDbContext<FilterListsDbContext>(options =>
                options.UseMySql(configuration.GetConnectionString("FilterListsConnection")));
            services.TryAddScoped<IFilterListRepository, FilterListRepository>();
            services.TryAddScoped<IFilterListService, FilterListService>();
        }
    }
}