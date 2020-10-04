using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace FilterLists.Archival.Api
{
    internal static class SwaggerExtensions
    {
        public static void AddSwaggerGen(this IServiceCollection services)
        {
            services.AddSwaggerGen(o =>
            {
                o.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "FilterLists Archival API",
                    Description =
                        "FilterLists is the independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances.",
                    Version = "v1",
                    //TermsOfService = "",
                    Contact = new OpenApiContact {Name = "FilterLists", Url = new Uri("https://filterlists.com")},
                    License = new OpenApiLicense
                    {
                        Name = "MIT License",
                        Url = new Uri("https://github.com/collinbarrett/FilterLists/blob/master/LICENSE")
                    }
                });
            });
        }

        public static void UseSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger(o =>
            {
                o.RouteTemplate = "{documentName}/swagger.json";
                o.PreSerializeFilters.Add((swaggerDoc, httpReq) => swaggerDoc.Servers = new List<OpenApiServer>
                {
#if DEBUG
                    new OpenApiServer {Url = $"{httpReq.Scheme}://{httpReq.Host.Value}:8080/api/archival"}
#else
                    new OpenApiServer {Url = $"https://{httpReq.Host.Value}/api/archival"}
#endif
                });
            });
        }
    }
}
