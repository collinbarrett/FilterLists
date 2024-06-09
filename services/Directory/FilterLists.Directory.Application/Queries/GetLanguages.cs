using System.Runtime.CompilerServices;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetLanguages
{
    private static readonly Func<QueryDbContext, IAsyncEnumerable<Response>> Query =
        EF.CompileAsyncQuery((QueryDbContext ctx) =>
            ctx.Languages
                .Where(l => l.FilterListLanguages.Any())
                .OrderBy(l => l.Iso6391)
                .Select(l => new Response(
                    l.Id,
                    l.Iso6391,
                    l.Name,
                    l.FilterListLanguages
                        .OrderBy(fl => fl.FilterListId)
                        .Select(fl => fl.FilterListId)
                ))
                .TagWith(nameof(GetLanguages))
        );

    public sealed record Request : IStreamRequest<Response>;

    [UsedImplicitly]
    private sealed class Handler(QueryDbContext ctx) : IStreamRequestHandler<Request, Response>
    {
        public async IAsyncEnumerable<Response> Handle(Request request,
            [EnumeratorCancellation] CancellationToken ct)
        {
            await foreach (var language in Query(ctx).WithCancellation(ct)) yield return language;
        }
    }

    /// <param name="Id" example="37">The identifier.</param>
    /// <param name="Iso6391" example="en">The unique ISO 639-1 code.</param>
    /// <param name="Name" example="English">The unique ISO name.</param>
    /// <param name="FilterListIds" example="[ 114, 141 ]">The identifiers of the FilterLists targeted by this Language.</param>
    [PublicAPI]
    public sealed record Response(short Id, string Iso6391, string Name, IEnumerable<int> FilterListIds);
}