using System.Text.Json.Serialization;
using FilterLists.Directory.Application;

namespace FilterLists.Directory.Api
{
    internal class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddRouting(o => o.LowercaseUrls = true);
            services.AddControllers().AddJsonOptions(o =>
                o.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull);
            services.AddSwaggerGen();
            services.AddApplicationServices(Configuration);
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseApplication();
            app.UseExceptionHandler(env.IsDevelopment() ? "/error-local-development" : "/error");
            app.UseRouting();
            app.UseEndpoints(e => e.MapControllers());
            app.UseSwagger();
        }
    }
}
