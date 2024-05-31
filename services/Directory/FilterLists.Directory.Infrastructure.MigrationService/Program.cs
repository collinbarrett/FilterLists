using FilterLists.Directory.Infrastructure;
using FilterLists.Directory.Infrastructure.MigrationService;

var builder = Host.CreateApplicationBuilder(args);
builder.AddInfrastructureForDbMaintenance();
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();