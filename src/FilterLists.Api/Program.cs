using FilterLists.Api.DependencyInjection.Extensions;
using FilterLists.Data;
using FilterLists.Data.Seed.Extensions;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Api
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                .Build()
                .MigrateAndSeedDbContext<FilterListsDbContext>((context, service) =>
                {
                    var dataPath = service.GetService<IConfiguration>()["DataDirectory:Path"].ToString();
                    SeedFilterListsDbContext.SeedOrUpdateAsync(context, dataPath).Wait();
                })
                .Run();
        }

        private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .UseUrls("http://localhost:5000")
                   .UseApplicationInsights()
                   .UseStartup<Startup>();
    }
}