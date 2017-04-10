using FilterLists.Data.Contexts;
using FilterLists.Data.Contracts.Repositories;
using FilterLists.Data.Repositories;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MySQL.Data.Entity.Extensions;

namespace FilterLists.Data.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        public static IServiceCollection RegisterFilterListsRepositories(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddSingleton(c => configuration);
            services.AddEntityFramework()
                .AddDbContext<FilterListsDbContext>(options =>
                    options.UseMySQL(configuration.GetConnectionString("FilterListsConnection")));
            services.TryAddScoped<IListRepository, ListRepository>();
            return services;
        }
    }
}