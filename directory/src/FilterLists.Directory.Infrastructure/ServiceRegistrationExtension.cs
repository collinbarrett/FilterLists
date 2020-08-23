using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Directory.Infrastructure
{
    public static class ServiceRegistrationExtension
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<QueryDbContext>(o =>
                o.UseNpgsql(configuration.GetConnectionString("DirectoryConnection")));
            services.AddScoped<IQueryContext, QueryContext>();
        }
    }
}