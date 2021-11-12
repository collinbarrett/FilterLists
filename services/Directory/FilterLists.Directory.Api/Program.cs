using System.Text.Json.Serialization;
using FilterLists.Directory.Api;
using FilterLists.Directory.Application;
using FilterLists.Directory.Infrastructure.Persistence;
using FilterLists.SharedKernel.Logging;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureApplication();
builder.Services.AddMemoryCache();
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
builder.Services.AddControllers()
    .AddJsonOptions(o => o.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplication(builder.Configuration);

var app = builder.Build();

app.UseApplication();
app.UseExceptionHandler(app.Environment.IsDevelopment() ? "/error-local-development" : "/error");
app.UseSwagger();
app.MapControllers();

await app.TryRunWithLoggingAsync(() => app.MigrateAsync());
