using FilterLists.Directory.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using static FilterLists.Directory.Api.OpenApi.OpenApiTags;
using static FilterLists.Directory.Application.Queries.GetListDetails;

namespace FilterLists.Directory.Api;

internal static class Endpoints
{
    internal static void MapEndpoints(this WebApplication app)
    {
        app.MapGet("/languages",
                (IMediator mediator, CancellationToken ct) =>
                    mediator.CreateStream(new GetLanguages.Request(), ct)
            )
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Tags = [LanguagesTag],
                Summary = "Gets the languages targeted by the FilterLists.",
                OperationId = nameof(GetLanguages)
            });

        app.MapGet("/licenses",
                (IMediator mediator, CancellationToken ct) =>
                    mediator.CreateStream(new GetLicenses.Request(), ct)
            )
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Tags = [LicensesTag],
                Summary = "Gets the licenses applied to the FilterLists.",
                OperationId = nameof(GetLicenses)
            });

        app.MapGet("/lists",
                (IMediator mediator, CancellationToken ct) =>
                    mediator.CreateStream(new GetLists.Request(), ct)
            )
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Tags = [FilterListsTag],
                Summary = "Gets the FilterLists.",
                OperationId = nameof(GetLists)
            });

        app.MapGet("/lists/{id:int}", async Task<Results<Ok<Response>, NotFound>>
                (int id, IMediator mediator, CancellationToken ct) =>
            {
                var list = await mediator.Send(new Request(id), ct);
                return list is not null
                    ? TypedResults.Ok(list)
                    : TypedResults.NotFound();
            })
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
                (IMediator mediator, CancellationToken ct) =>
                    mediator.CreateStream(new GetMaintainers.Request(), ct)
            )
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Tags = [MaintainersTag],
                Summary = "Gets the maintainers of the FilterLists.",
                OperationId = nameof(GetMaintainers)
            });

        app.MapGet("/software",
                (IMediator mediator, CancellationToken ct) =>
                    mediator.CreateStream(new GetSoftware.Request(), ct)
            )
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Tags = [SoftwareTag],
                Summary = "Gets the software that subscribes to the FilterLists.",
                OperationId = nameof(GetSoftware)
            });

        app.MapGet("/syntaxes",
                (IMediator mediator, CancellationToken ct) =>
                    mediator.CreateStream(new GetSyntaxes.Request(), ct)
            )
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Tags = [SyntaxesTag],
                Summary = "Gets the syntaxes of the FilterLists.",
                OperationId = nameof(GetSyntaxes)
            });

        app.MapGet("/tags",
                (IMediator mediator, CancellationToken ct) =>
                    mediator.CreateStream(new GetTags.Request(), ct)
            )
            .WithOpenApi(operation => new OpenApiOperation(operation)
            {
                Tags = [TagsTag],
                Summary = "Gets the tags of the FilterLists.",
                OperationId = nameof(GetTags)
            });
    }
}