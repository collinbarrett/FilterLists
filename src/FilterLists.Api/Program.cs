using FilterLists.Data;
using FilterLists.Data.Contexts;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);
            //using (var scope = host.Services.CreateScope())
            //{
            //    DbInitializer.Initialize(scope.ServiceProvider.GetRequiredService<FilterListsDbContext>());
            //}
            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseApplicationInsights()
                .UseStartup<Startup>()
                .Build();
        }
    }
}