using Projects;

var builder = DistributedApplication.CreateBuilder(args);

// var appInsights = builder.AddAzureApplicationInsights("appinsights");

var directoryDb = builder.AddSqlServer("directorysqlserver")
    .WithDataVolume()
    .AddDatabase("directorydb");

builder.AddProject<FilterLists_Directory_Api>("directoryapi")
    .WithReference(directoryDb)
    // .WithReference(appInsights)
    .WithExternalHttpEndpoints();

builder.Build().Run();