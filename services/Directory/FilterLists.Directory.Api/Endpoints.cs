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
            .AddOpenApiOperationTransformer((operation, context, ct) =>
            {
                operation.Tags = new HashSet<OpenApiTagReference> { new(LanguagesTag.Name!) };
                operation.Summary = "Gets the languages targeted by the FilterLists.";
                operation.OperationId = nameof(GetLanguages);
                return Task.CompletedTask;
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");

        app.MapGet("/licenses",
                async (GetLicenses.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetLicenses.Response>>()
            .AddOpenApiOperationTransformer((operation, context, ct) =>
            {
                operation.Tags = new HashSet<OpenApiTagReference> { new(LicensesTag.Name!) };
                operation.Summary = "Gets the licenses applied to the FilterLists.";
                operation.OperationId = nameof(GetLicenses);
                return Task.CompletedTask;
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");

        app.MapGet("/lists",
                async (GetLists.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetLists.Response>>()
            .AddOpenApiOperationTransformer((operation, context, ct) =>
            {
                operation.Tags = new HashSet<OpenApiTagReference> { new(FilterListsTag.Name!) };
                operation.Summary = "Gets the FilterLists.";
                operation.OperationId = nameof(GetLists);
                return Task.CompletedTask;
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
            .AddOpenApiOperationTransformer((operation, context, ct) =>
            {
                operation.Tags = new HashSet<OpenApiTagReference> { new(FilterListsTag.Name!) };
                operation.Summary = "Gets the details of the FilterList.";
                operation.OperationId = nameof(GetListDetails);
                operation.Parameters =
                [
                    new OpenApiParameter
                    {
                        Name = "id",
                        In = ParameterLocation.Path,
                        Description = "The identifier of the FilterList.",
                        Required = true,
                        Example = JsonValue.Create(1)
                    }
                ];
                return Task.CompletedTask;
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");

        app.MapGet("/maintainers",
                async (GetMaintainers.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetMaintainers.Response>>()
            .AddOpenApiOperationTransformer((operation, context, ct) =>
            {
                operation.Tags = new HashSet<OpenApiTagReference> { new(MaintainersTag.Name!) };
                operation.Summary = "Gets the maintainers of the FilterLists.";
                operation.OperationId = nameof(GetMaintainers);
                return Task.CompletedTask;
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");

        app.MapGet("/software",
                async (GetSoftware.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetSoftware.Response>>()
            .AddOpenApiOperationTransformer((operation, context, ct) =>
            {
                operation.Tags = new HashSet<OpenApiTagReference> { new(SoftwareTag.Name!) };
                operation.Summary = "Gets the software that subscribes to the FilterLists.";
                operation.OperationId = nameof(GetSoftware);
                return Task.CompletedTask;
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");

        app.MapGet("/syntaxes",
                async (GetSyntaxes.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetSyntaxes.Response>>()
            .AddOpenApiOperationTransformer((operation, context, ct) =>
            {
                operation.Tags = new HashSet<OpenApiTagReference> { new(SyntaxesTag.Name!) };
                operation.Summary = "Gets the syntaxes of the FilterLists.";
                operation.OperationId = nameof(GetSyntaxes);
                return Task.CompletedTask;
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");

        app.MapGet("/tags",
                async (GetTags.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetTags.Response>>()
            .AddOpenApiOperationTransformer((operation, context, ct) =>
            {
                operation.Tags = new HashSet<OpenApiTagReference> { new(TagsTag.Name!) };
                operation.Summary = "Gets the tags of the FilterLists.";
                operation.OperationId = nameof(GetTags);
                return Task.CompletedTask;
            })
            .AddEndpointFilter(DefaultGetCacheFilter)
            .CacheOutput("ExpireDay");
    }
}