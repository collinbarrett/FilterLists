using System.Runtime.CompilerServices;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetTags
{
    private static readonly Func<QueryDbContext, IAsyncEnumerable<TagVm>> Query =
        EF.CompileAsyncQuery((QueryDbContext ctx) =>
            ctx.Tags
                .Where(t => t.FilterListTags.Any())
                .OrderBy(t => t.Id)
                .Select(t => new TagVm
                {
                    Id = t.Id,
                    Name = t.Name,
                    Description = t.Description,
                    FilterListIds = t.FilterListTags
                        .OrderBy(flt => flt.FilterListId)
                        .Select(flt => flt.FilterListId)
                })
                .TagWith(nameof(GetTags))
        );

    public sealed record Request : IStreamRequest<TagVm>;

    [UsedImplicitly]
    private sealed class Handler(QueryDbContext ctx) : IStreamRequestHandler<Request, TagVm>
    {
        public async IAsyncEnumerable<TagVm> Handle(Request request,
            [EnumeratorCancellation] CancellationToken ct)
        {
            await foreach (var tag in Query(ctx).WithCancellation(ct)) yield return tag;
        }
    }

    [PublicAPI]
    public record TagVm
    {
        /// <summary>
        ///     The identifier.
        /// </summary>
        /// <example>2</example>
        public int Id { get; init; }

        /// <summary>
        ///     The unique name.
        /// </summary>
        /// <example>ads</example>
        public required string Name { get; init; }

        /// <summary>
        ///     The description.
        /// </summary>
        /// <example>Blocks advertisements</example>
        public string? Description { get; init; }

        /// <summary>
        ///     The identifiers of the FilterLists to which this Tag is applied.
        /// </summary>
        /// <example>[ 1, 3, 6 ]</example>
        public IEnumerable<int> FilterListIds { get; init; } = [];
    }
}