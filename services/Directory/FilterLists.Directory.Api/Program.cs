using FilterLists.Directory.Api;
using FilterLists.Directory.Api.OpenApi;
using FilterLists.Directory.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy.WithOrigins("https://filterlists.com", "https://aspire.filterlists.com") // TODO: rm 'aspire.' when merging aspire to main
        .WithMethods("GET")
        .AllowAnyHeader()));
builder.WebHost.ConfigureKestrel(serverOptions => serverOptions.AddServerHeader = false);
builder.AddServiceDefaults();
builder.Services.AddProblemDetails();
builder.Services.AddOpenApiGen();
builder.AddApplication();

var app = builder.Build();

app.UseExceptionHandler();
app.UseCors();
app.MapEndpoints();
app.MapDefaultEndpoints();
app.UseSwaggerCustom();

app.Run();