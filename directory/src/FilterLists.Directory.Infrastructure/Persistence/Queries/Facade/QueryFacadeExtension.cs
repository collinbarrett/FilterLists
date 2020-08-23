using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Facade
{
    public static class QueryFacadeExtension
    {
        public static void RegisterQueryFacade(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<QueryDbContext>(o =>
                o.UseNpgsql(configuration.GetConnectionString("DirectoryConnection")));
            services.AddScoped<IQueryDirectory, QueryFacade>();
        }
    }
}