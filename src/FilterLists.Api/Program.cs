using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using FilterLists.Api.DependencyInjection.Extensions;
using FilterLists.Data.Seed.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Api
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().MigrateDbContext<Data.FilterListsDbContext>((context,service)=>
            {

                var dataPath = service.GetService<IConfiguration>()["DataDirectory:Path"].ToString();
                new SeedFilterListsDbContext().SeedOrUpdateAsync(context,dataPath).Wait();
            }).Run();
        }
        private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .UseUrls("http://localhost:5000")
                   .UseApplicationInsights()
                   .UseStartup<Startup>();
    }
}