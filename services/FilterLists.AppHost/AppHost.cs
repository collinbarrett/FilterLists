var builder = DistributedApplication.CreateBuilder(args);

var directoryDb = builder.AddSqlServer("directorysqlserver")
    .WithDataVolume()
    .AddDatabase("directorydb");

builder.AddDotnetProject("directoryapi", "../Directory/FilterLists.Directory.Api/FilterLists.Directory.Api.csproj")
    .WithReference(directoryDb)
    .WaitFor(directoryDb)
    .WithExternalHttpEndpoints();

builder.Build().Run();