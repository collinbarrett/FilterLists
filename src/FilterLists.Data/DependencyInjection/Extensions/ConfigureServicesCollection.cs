using FilterLists.Data.Contexts;
using FilterLists.Data.Repositories.Contracts;
using FilterLists.Data.Repositories.Implementations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MySQL.Data.Entity.Extensions;

namespace FilterLists.Data.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        public static void AddFilterListsRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(c => configuration);
            services.AddEntityFramework()
                .AddDbContext<FilterListsDbContext>(options =>
                    options.UseMySQL(configuration.GetConnectionString("FilterListsConnection")));
            services.TryAddScoped<IListRepository, ListRepository>();
            services.TryAddScoped<ITableCsvRepository, TableCsvRepository>();
        }
    }
}