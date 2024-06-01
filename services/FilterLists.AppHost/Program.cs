var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.FilterLists_ApiService>("apiservice");

builder.AddProject<Projects.FilterLists_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
