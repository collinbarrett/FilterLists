using FilterLists.Api.DependencyInjection.Extensions;
using FilterLists.Data.DependencyInjection.Extensions;
using FilterLists.Services.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddFilterListsRepositories(Configuration);
            services.AddFilterListsServices();
            services.AddFilterListsApi();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}