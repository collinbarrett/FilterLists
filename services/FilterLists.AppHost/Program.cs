using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var directoryDb = builder.AddSqlServer("directorysqlserver")
    .WithDataVolume()
    .AddDatabase("directorydb");

builder.AddProject<FilterLists_Directory_Api>("directoryapi")
    .WithReference(directoryDb)
    .WithExternalHttpEndpoints();

builder.Build().Run();