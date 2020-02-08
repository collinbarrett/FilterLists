using FilterLists.Api.DependencyInjection.Extensions;
using FilterLists.Data;
using FilterLists.Data.Seed.Extensions;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace FilterLists.Api
{
    public static class Program
    {
        private const string DataPath = "../data";

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                .Build()
                .MigrateAndSeedDbContext<FilterListsDbContext>((context, service) =>
                {
                    SeedFilterListsDbContext.SeedOrUpdateAsync(context, DataPath).Wait();
                })
                .Run();
        }

        private static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
        }
    }
}