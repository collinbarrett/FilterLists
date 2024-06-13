using FilterLists.Directory.Api;
using FilterLists.Directory.Api.OpenApi;
using FilterLists.Directory.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
{
    policy.SetIsOriginAllowed(origin =>
        {
            if (origin == "https://filterlists.com") return true;
            return origin.StartsWith("https://nice-water-05873140f", StringComparison.InvariantCulture) &&
                   origin.EndsWith(".eastus2.5.azurestaticapps.net", StringComparison.InvariantCulture);
        })
        .WithMethods("GET")
        .AllowAnyHeader();
}));
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