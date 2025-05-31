using FilterLists.Directory.Application.Queries;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using static FilterLists.Directory.Api.OpenApi.OpenApiTags;

namespace FilterLists.Directory.Api;

internal static class Endpoints
{
    internal static void MapEndpoints(this WebApplication app)
    {
        app.MapGet("/languages", async (GetLanguages.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetLanguages.Response>>()
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Tags = [LanguagesTag],
                Summary = "Gets the languages targeted by the FilterLists.",
                OperationId = nameof(GetLanguages)
            });

        app.MapGet("/licenses", async (GetLicenses.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetLicenses.Response>>()
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Tags = [LicensesTag],
                Summary = "Gets the licenses applied to the FilterLists.",
                OperationId = nameof(GetLicenses)
            });

        app.MapGet("/lists", async (GetLists.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetLists.Response>>()
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Tags = [FilterListsTag],
                Summary = "Gets the FilterLists.",
                OperationId = nameof(GetLists)
            });

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
                Tags = [FilterListsTag],
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
                        Example = new OpenApiInteger(1)
                    }
                ]
            });

        app.MapGet("/maintainers",
                async (GetMaintainers.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetMaintainers.Response>>()
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Tags = [MaintainersTag],
                Summary = "Gets the maintainers of the FilterLists.",
                OperationId = nameof(GetMaintainers)
            });

        app.MapGet("/software", async (GetSoftware.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetSoftware.Response>>()
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Tags = [SoftwareTag],
                Summary = "Gets the software that subscribes to the FilterLists.",
                OperationId = nameof(GetSoftware)
            });

        app.MapGet("/syntaxes", async (GetSyntaxes.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetSyntaxes.Response>>()
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Tags = [SyntaxesTag],
                Summary = "Gets the syntaxes of the FilterLists.",
                OperationId = nameof(GetSyntaxes)
            });

        app.MapGet("/tags", async (GetTags.Query query, CancellationToken ct) => await query.ExecuteAsync(ct))
            .Produces<List<GetTags.Response>>()
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Tags = [TagsTag],
                Summary = "Gets the tags of the FilterLists.",
                OperationId = nameof(GetTags)
            });
    }
}