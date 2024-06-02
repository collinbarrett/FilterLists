using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var appInsights = builder.AddAzureApplicationInsights("appinsights");

// TODO: use separate users (db_ddladmin only for migrations) https://stackoverflow.com/q/78564037/2343739
var directoryDb = builder.AddSqlServer("directorysqlserver")
    .PublishAsConnectionString() // customized Azure resource for free tier, don't yet trust Aspire to provision db
    .WithDataVolume() // don't re-seed db on every startup locally, requires https://learn.microsoft.com/en-us/dotnet/aspire/fundamentals/persist-data-volumes#create-a-persistent-password
    .AddDatabase("directorydb");

// TODO: migrate published db from run-once instance (Container Apps 'App" type restarts)
if (!builder.ExecutionContext.IsPublishMode)
    builder.AddProject<FilterLists_Directory_Infrastructure_MigrationService>("directorymigrationservice")
        .WithReference(directoryDb)
        .WithReference(appInsights);

var directoryApi = builder.AddProject<FilterLists_Directory_Api>("directoryapi")
    .WithReference(directoryDb)
    .WithReference(appInsights)
    .WithExternalHttpEndpoints();

builder.Build().Run();