using FilterLists.Directory.Api;
using FilterLists.Directory.Api.OpenApi;
using FilterLists.Directory.Application;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(serverOptions => serverOptions.AddServerHeader = false);
builder.AddServiceDefaults();
builder.Services.AddCors(CorsConfiguration.SetupAction);
builder.Services.AddProblemDetails();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(OpenApiGenConfiguration.SetupAction);
builder.AddApplication();

var app = builder.Build();

app.UseExceptionHandler();
app.UseCors();

// TEMP: allow Cloudflare to cache all responses since data changes infrequently
app.Use(async (context, next) =>
{
    await next();
    context.Response.Headers.Remove("Vary");
});

app.MapEndpoints();
app.MapDefaultEndpoints();
app.UseSwagger(o => o.RouteTemplate = "{documentName}/openapi.json");
app.UseSwaggerUI(SwaggerUiConfiguration.SetupAction);

app.Run();