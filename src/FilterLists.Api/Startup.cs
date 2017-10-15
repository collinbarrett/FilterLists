using System.IO;
using FilterLists.Api.DependencyInjection.Extensions;
using FilterLists.Data.DependencyInjection.Extensions;
using FilterLists.Services.DependencyInjection.Extensions;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Api
{
    public class Startup
    {
        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            Configuration = builder.Build();
        }

        private IConfigurationRoot Configuration { get; }

        [UsedImplicitly]
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddFilterListsRepositories(Configuration);
            services.AddFilterListsServices();
            services.AddFilterListsApi();
        }

        [UsedImplicitly]
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}