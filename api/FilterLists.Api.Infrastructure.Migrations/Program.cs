using FilterLists.Api.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

const string connectionStringKey = "ddladminConnectionString";
builder.Services.AddInfrastructure(builder.Configuration.GetConnectionString(connectionStringKey) ??
                                   throw new InvalidOperationException($"Missing {connectionStringKey}"));

var app = builder.Build();

app.Run();