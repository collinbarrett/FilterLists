using FilterLists.Directory.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using static FilterLists.Directory.Application.Queries.GetListDetails;

namespace FilterLists.Directory.Api;

internal static class Endpoints
{
    internal static void MapEndpoints(this WebApplication app)
    {
        app.MapGet("/languages",
            (IMediator mediator, CancellationToken ct) =>
                mediator.CreateStream(new GetLanguages.Request(), ct)
        );

        app.MapGet("/licenses",
            (IMediator mediator, CancellationToken ct) =>
                mediator.CreateStream(new GetLicenses.Request(), ct)
        );

        app.MapGet("/lists",
            (IMediator mediator, CancellationToken ct) =>
                mediator.CreateStream(new GetLists.Request(), ct)
        );

        app.MapGet("/lists/{id:int}", async Task<Results<Ok<ListDetailsVm>, NotFound>>
            (int id, IMediator mediator, CancellationToken ct) =>
        {
            var list = await mediator.Send(new Request(id), ct);
            return list is not null
                ? TypedResults.Ok(list)
                : TypedResults.NotFound();
        });

        app.MapGet("/maintainers",
            (IMediator mediator, CancellationToken ct) =>
                mediator.CreateStream(new GetMaintainers.Request(), ct)
        );

        app.MapGet("/software",
            (IMediator mediator, CancellationToken ct) =>
                mediator.CreateStream(new GetSoftware.Request(), ct)
        );

        app.MapGet("/syntaxes",
            (IMediator mediator, CancellationToken ct) =>
                mediator.CreateStream(new GetSyntaxes.Request(), ct)
        );

        app.MapGet("/tags",
            (IMediator mediator, CancellationToken ct) =>
                mediator.CreateStream(new GetTags.Request(), ct)
        );
    }
}