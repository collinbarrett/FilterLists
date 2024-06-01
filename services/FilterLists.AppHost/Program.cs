using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<FilterLists_ApiService>("apiservice");

builder.AddProject<FilterLists_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();