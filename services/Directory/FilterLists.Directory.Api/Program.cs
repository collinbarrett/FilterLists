using FilterLists.Directory.Api;
using FilterLists.Directory.Api.Cors;
using FilterLists.Directory.Api.OpenApi;
using FilterLists.Directory.Application;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(serverOptions => serverOptions.AddServerHeader = false);
builder.Services.AddRequestTimeouts();
builder.Services.AddOutputCache();
builder.AddServiceDefaults();
builder.Services.AddCors(options => CorsConfiguration.SetupAction(options, builder.Configuration));
builder.Services.AddProblemDetails();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(OpenApiGenConfiguration.SetupAction);
builder.AddApplication();

var app = builder.Build();

app.UseExceptionHandler();
app.UseCors();
app.UseRequestTimeouts();
app.UseOutputCache();
app.MapEndpoints();
app.MapDefaultEndpoints();
app.UseSwagger(o => o.RouteTemplate = "{documentName}/openapi.json");
app.UseSwaggerUI(SwaggerUiConfiguration.SetupAction);

app.Run();