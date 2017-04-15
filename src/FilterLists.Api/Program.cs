using System.IO;
//using JetBrains.Annotations;
using Microsoft.AspNetCore.Hosting;

namespace FilterLists.Api
{
    //[UsedImplicitly]
    public class Program
    {
        //[UsedImplicitly]
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