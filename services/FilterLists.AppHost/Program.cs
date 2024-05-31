using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var appInsights = builder.AddAzureApplicationInsights("appinsights");

// TODO: use separate users (db_ddladmin only for migrations) https://stackoverflow.com/q/78564037/2343739
var directoryDb = builder.AddSqlServer("directorysqlserver")
    .PublishAsConnectionString() // customized for free tier, don't trust Aspire to provision db
    .AddDatabase("directorydb");

builder.AddProject<FilterLists_Directory_Infrastructure_MigrationService>("directorymigrationservice")
    .WithReference(directoryDb)
    .WithReference(appInsights);

var directoryApi = builder.AddProject<FilterLists_Directory_Api>("directoryapi")
    .WithReference(directoryDb)
    .WithReference(appInsights);

builder.AddProject<FilterLists_Web>("web")
    .WithReference(directoryApi)
    .WithReference(appInsights)
    .WithExternalHttpEndpoints();

builder.Build().Run();