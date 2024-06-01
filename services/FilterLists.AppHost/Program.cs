using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var directoryApi = builder.AddProject<FilterLists_ApiService>("directoryapi");

builder.AddProject<FilterLists_Web>("web")
    .WithReference(directoryApi)
    .WithExternalHttpEndpoints();

builder.Build().Run();