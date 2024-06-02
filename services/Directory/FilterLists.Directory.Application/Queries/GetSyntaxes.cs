using System.Runtime.CompilerServices;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetSyntaxes
{
    private static readonly Func<QueryDbContext, IAsyncEnumerable<SyntaxVm>> Query =
        EF.CompileAsyncQuery((QueryDbContext ctx) =>
            ctx.Syntaxes
                .Where(s => s.FilterListSyntaxes.Any())
                .OrderBy(s => s.Id)
                .Select(s => new SyntaxVm
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    Url = s.Url,
                    FilterListIds = s.FilterListSyntaxes
                        .OrderBy(fs => fs.FilterListId)
                        .Select(fs => fs.FilterListId),
                    SoftwareIds = s.SoftwareSyntaxes
                        .OrderBy(ss => ss.SoftwareId)
                        .Select(ss => ss.SoftwareId)
                })
                .TagWith(nameof(GetSyntaxes))
        );

    public sealed record Request : IStreamRequest<SyntaxVm>;

    [UsedImplicitly]
    private sealed class Handler(QueryDbContext ctx) : IStreamRequestHandler<Request, SyntaxVm>
    {
        public async IAsyncEnumerable<SyntaxVm> Handle(Request request,
            [EnumeratorCancellation] CancellationToken ct)
        {
            await foreach (var syntax in Query(ctx).WithCancellation(ct)) yield return syntax;
        }
    }

    [PublicAPI]
    public record SyntaxVm
    {
        /// <summary>
        ///     The identifier.
        /// </summary>
        /// <example>3</example>
        public short Id { get; init; }

        /// <summary>
        ///     The unique name.
        /// </summary>
        /// <example>Adblock Plus</example>
        public required string Name { get; init; }

        /// <summary>
        ///     The description.
        /// </summary>
        /// <example>null</example>
        public string? Description { get; init; }

        /// <summary>
        ///     The URL of the home page.
        /// </summary>
        /// <example>https://adblockplus.org/filters</example>
        public Uri? Url { get; init; }

        /// <summary>
        ///     The identifiers of the FilterLists implementing this Syntax.
        /// </summary>
        /// <example>[ 2, 6, 11 ]</example>
        public IEnumerable<int> FilterListIds { get; init; } = [];

        /// <summary>
        ///     The identifiers of the Software that supports this Syntax.
        /// </summary>
        /// <example>[ 1, 2, 3 ]</example>
        public IEnumerable<short> SoftwareIds { get; init; } = [];
    }
}