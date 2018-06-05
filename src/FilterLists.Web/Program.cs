using JetBrains.Annotations;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace FilterLists.Web
{
    [UsedImplicitly]
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        private static IWebHostBuilder CreateWebHostBuilder(string[] args) => WebHost
                                                                              .CreateDefaultBuilder(args)
                                                                              .UseUrls("http://localhost:5001;")
                                                                              .UseStartup<Startup>();
    }
}