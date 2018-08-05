using System.Linq;
using FilterLists.Api.DependencyInjection.Extensions;
using FilterLists.Data;
using FilterLists.Data.Seed.Extensions;
using FilterLists.Services.DependencyInjection.Extensions;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace FilterLists.Api
{
    [UsedImplicitly]
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        [UsedImplicitly]
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddFilterListsServices(Configuration);
            services.AddFilterListsApi();
        }

        [UsedImplicitly]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseMvc();
            app.UseSwagger(opts =>
            {
                opts.PreSerializeFilters.Add((swaggerDoc, httpReq) => swaggerDoc.Host = httpReq.Host.Value);
                //TODO: remove preprocessor directives
#if RELEASE
                opts.PreSerializeFilters.Add((swaggerDoc, httpReq) => swaggerDoc.BasePath = "/api");
#endif
                opts.RouteTemplate = "docs/{documentName}/swagger.json";
                UseLowercaseControllerNameInSwaggerHack(opts);
            });
            app.UseSwaggerUI(opts =>
            {
                opts.SwaggerEndpoint("v1/swagger.json", "FilterLists API v1");
                opts.DocumentTitle = "FilterLists API v1";
                opts.RoutePrefix = "docs";
            });
            MigrateAndSeedDatabase(app);
        }

        //TODO: remove hack (https://github.com/domaindrivendev/Swashbuckle.AspNetCore/issues/74#issuecomment-386762178)
        private static void UseLowercaseControllerNameInSwaggerHack(SwaggerOptions opts)
        {
            opts.PreSerializeFilters.Add((document, request) =>
            {
                var paths = document.Paths.ToDictionary(item => item.Key.ToLowerInvariant(), item => item.Value);
                document.Paths.Clear();
                foreach (var pathItem in paths)
                    document.Paths.Add(pathItem.Key, pathItem.Value);
            });
        }

        private void MigrateAndSeedDatabase(IApplicationBuilder app)
        {
            var dataPath = Configuration.GetSection("DataDirectory").GetValue<string>("Path");
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var filterListsDbContext = serviceScope.ServiceProvider.GetService<FilterListsDbContext>();
                filterListsDbContext.Database.Migrate();
                filterListsDbContext.SeedOrUpdate(dataPath);
            }
        }
    }
}