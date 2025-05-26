using FilterLists.Directory.Api;
using FilterLists.Directory.Api.OpenApi;
using FilterLists.Directory.Application;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(serverOptions => serverOptions.AddServerHeader = false);

// for health checks: https://learn.microsoft.com/en-us/dotnet/aspire/fundamentals/health-checks#non-development-environments
builder.Services.AddRequestTimeouts();
builder.Services.AddOutputCache();

builder.AddServiceDefaults();
builder.Services.AddCors(CorsConfiguration.SetupAction);
builder.Services.AddProblemDetails();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(OpenApiGenConfiguration.SetupAction);

builder.AddApplication();

var app = builder.Build();

app.UseExceptionHandler();
app.UseCors();
app.MapEndpoints();

// for health checks: https://learn.microsoft.com/en-us/dotnet/aspire/fundamentals/health-checks#non-development-environments
app.UseRequestTimeouts();
app.UseOutputCache();

app.MapDefaultEndpoints();
app.UseSwagger(o => o.RouteTemplate = "{documentName}/openapi.json");
app.UseSwaggerUI(SwaggerUiConfiguration.SetupAction);

app.Run();