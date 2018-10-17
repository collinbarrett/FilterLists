using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Api.DependencyInjection.Extensions
{
    // ReSharper disable once InconsistentNaming
    public static class IWebHostExtensions
    {
        public static IWebHost MigrateAndSeedDbContext<TContext>(this IWebHost webHost,
            Action<TContext, IServiceProvider> seeder) where TContext : DbContext
        {
            using (var scope = webHost.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetService<TContext>();
                context.Database.Migrate();
                seeder(context, services);
            }

            return webHost;
        }
    }
}