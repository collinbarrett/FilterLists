using System.Runtime.CompilerServices;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetLanguages
{
    private static readonly Func<QueryDbContext, IAsyncEnumerable<LanguageVm>> Query =
        EF.CompileAsyncQuery((QueryDbContext ctx) =>
            ctx.Languages
                .Where(l => l.FilterListLanguages.Any())
                .OrderBy(l => l.Iso6391)
                .Select(l => new LanguageVm
                {
                    Id = l.Id,
                    Iso6391 = l.Iso6391,
                    Name = l.Name,
                    FilterListIds = l.FilterListLanguages
                        .OrderBy(fl => fl.FilterListId)
                        .Select(fl => fl.FilterListId)
                })
                .TagWith(nameof(GetLanguages))
        );

    public sealed record Request : IStreamRequest<LanguageVm>;

    [UsedImplicitly]
    private sealed class Handler(QueryDbContext ctx) : IStreamRequestHandler<Request, LanguageVm>
    {
        public async IAsyncEnumerable<LanguageVm> Handle(Request request, [EnumeratorCancellation] CancellationToken ct)
        {
            await foreach (var language in Query(ctx).WithCancellation(ct)) yield return language;
        }
    }

    [PublicAPI]
    public record LanguageVm
    {
        /// <summary>
        ///     The identifier.
        /// </summary>
        /// <example>37</example>
        public short Id { get; init; }

        /// <summary>
        ///     The unique ISO 639-1 code.
        /// </summary>
        /// <example>en</example>
        public required string Iso6391 { get; init; }

        /// <summary>
        ///     The unique ISO name.
        /// </summary>
        /// <example>English</example>
        public required string Name { get; init; }

        /// <summary>
        ///     The identifiers of the FilterLists targeted by this Language.
        /// </summary>
        /// <example>[ 114, 141 ]</example>
        public IEnumerable<int> FilterListIds { get; init; } = [];
    }
}