using System.Reflection;
using Microsoft.OpenApi.Models;

namespace FilterLists.Archival.Api;

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
                    "An ASP.NET Core API archiving and serving copies of FilterLists for mirrors and analysis.",
                Version = "v1",
                //TermsOfService = "",
                Contact = new OpenApiContact { Name = "FilterLists", Url = new Uri("https://filterlists.com") },
                License = new OpenApiLicense
                {
                    Name = "MIT License",
                    Url = new Uri("https://github.com/collinbarrett/FilterLists/blob/master/LICENSE")
                }
            });

            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            o.IncludeXmlComments(xmlPath);
        });
    }

    public static void UseSwagger(this IApplicationBuilder app)
    {
        app.UseSwagger(o =>
        {
            o.RouteTemplate = "{documentName}/swagger.json";
            o.PreSerializeFilters.Add((swaggerDoc, httpReq) => swaggerDoc.Servers = new List<OpenApiServer>
            {
                new() { Url = $"{httpReq.Scheme}://{httpReq.Host.Value}/api/archival" }
            });
        });
    }
}
