using FilterLists.Directory.Api;
using FilterLists.Directory.Api.OpenApi;
using FilterLists.Directory.Application;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(serverOptions => serverOptions.AddServerHeader = false);
builder.AddServiceDefaults();
builder.Services.AddProblemDetails();
builder.Services.AddOpenApiGen();
builder.AddApplication();

var app = builder.Build();

app.UseExceptionHandler();
app.MapEndpoints();
app.MapDefaultEndpoints();
app.UseSwagger();
app.UseSwaggerUI();

app.Run();