using System.Text.Json.Nodes;
using FilterLists.Directory.Application.Queries;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.OpenApi;
using static FilterLists.Directory.Api.OpenApi.OpenApiTags;

namespace FilterLists.Directory.Api;

internal static class Endpoints
{
    private static readonly CacheControlFilter DefaultGetCacheFilter = new(900, 86400);

    internal static void MapEndpoints(this WebApplication app)
    {
        app.MapGet("/languages",
                async (GetLanguages.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetLanguages.Response>>()
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Summary = "Gets the languages targeted by the FilterLists.",
                OperationId = nameof(GetLanguages)
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");

        app.MapGet("/licenses",
                async (GetLicenses.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetLicenses.Response>>()
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Summary = "Gets the licenses applied to the FilterLists.",
                OperationId = nameof(GetLicenses)
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");

        app.MapGet("/lists",
                async (GetLists.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetLists.Response>>()
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Summary = "Gets the FilterLists.",
                OperationId = nameof(GetLists)
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");

        app.MapGet("/lists/{id:int}",
                async Task<Results<Ok<GetListDetails.Response>, NotFound>>
                    (int id, GetListDetails.Query query, CancellationToken ct) =>
                {
                    var list = await query.ExecuteAsync(id, ct);
                    return list is not null
                        ? TypedResults.Ok(list)
                        : TypedResults.NotFound();
                })
            .Produces<GetListDetails.Response>()
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Summary = "Gets the details of the FilterList.",
                OperationId = nameof(GetListDetails),
                Parameters =
                [
                    new OpenApiParameter
                    {
                        Name = "id",
                        In = ParameterLocation.Path,
                        Description = "The identifier of the FilterList.",
                        Required = true,
                        Example = JsonValue.Create(1)
                    }
                ]
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");

        app.MapGet("/maintainers",
                async (GetMaintainers.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetMaintainers.Response>>()
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Summary = "Gets the maintainers of the FilterLists.",
                OperationId = nameof(GetMaintainers)
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");

        app.MapGet("/software",
                async (GetSoftware.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetSoftware.Response>>()
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Summary = "Gets the software that subscribes to the FilterLists.",
                OperationId = nameof(GetSoftware)
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");

        app.MapGet("/syntaxes",
                async (GetSyntaxes.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetSyntaxes.Response>>()
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Summary = "Gets the syntaxes of the FilterLists.",
                OperationId = nameof(GetSyntaxes)
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");

        app.MapGet("/tags",
                async (GetTags.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetTags.Response>>()
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Summary = "Gets the tags of the FilterLists.",
                OperationId = nameof(GetTags)
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");
    }
}