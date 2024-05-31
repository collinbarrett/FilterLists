using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Directory.Infrastructure;

public static class ConfigurationExtensions
{
    public static void AddInfrastructureForDbMaintenance(this IHostApplicationBuilder builder)
    {
        builder.AddSqlServerDbContext<QueryDbContext>("directorydb",
            settings => { },
            o => o.UseSqlServer(so => so.MigrationsAssembly("FilterLists.Directory.Infrastructure.Migrations"))
        );
    }
}