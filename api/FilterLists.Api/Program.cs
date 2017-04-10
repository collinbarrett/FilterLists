using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FilterLists.Api
{
    // ReSharper disable once UnusedMember.Global
    public class Program
    {
        // ReSharper disable once UnusedMember.Global
        // ReSharper disable once UnusedParameter.Global
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls("http://localhost:5123")
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
    }
}