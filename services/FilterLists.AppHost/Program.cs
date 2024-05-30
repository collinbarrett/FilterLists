using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var appInsights = builder.AddAzureApplicationInsights("appinsights");

var directoryApi = builder.AddProject<FilterLists_Directory_Api>("directoryapi")
    .WithReference(appInsights);

builder.AddProject<FilterLists_Web>("web")
    .WithReference(directoryApi)
    .WithReference(appInsights)
    .WithExternalHttpEndpoints();

builder.Build().Run();