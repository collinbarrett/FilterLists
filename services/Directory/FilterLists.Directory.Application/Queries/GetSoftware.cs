using System.Runtime.CompilerServices;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetSoftware
{
    private static readonly Func<QueryDbContext, IAsyncEnumerable<SoftwareVm>> Query =
        EF.CompileAsyncQuery((QueryDbContext ctx) =>
            ctx.Software
                .Where(s => s.SoftwareSyntaxes
                    .Any(ss => ss.Syntax.FilterListSyntaxes.Any()))
                .OrderBy(s => s.Id)
                .Select(s => new SoftwareVm
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    HomeUrl = s.HomeUrl,
                    DownloadUrl = s.DownloadUrl,
                    SupportsAbpUrlScheme = s.SupportsAbpUrlScheme,
                    SyntaxIds = s.SoftwareSyntaxes
                        .OrderBy(ss => ss.SyntaxId)
                        .Select(ss => ss.SyntaxId)
                })
                .TagWith(nameof(GetSoftware))
        );

    public sealed record Request : IStreamRequest<SoftwareVm>;

    [UsedImplicitly]
    private sealed class Handler(QueryDbContext ctx) : IStreamRequestHandler<Request, SoftwareVm>
    {
        public async IAsyncEnumerable<SoftwareVm> Handle(Request request,
            [EnumeratorCancellation] CancellationToken ct)
        {
            await foreach (var software in Query(ctx).WithCancellation(ct)) yield return software;
        }
    }

    [PublicAPI]
    public sealed record SoftwareVm
    {
        /// <summary>
        ///     The identifier.
        /// </summary>
        /// <example>2</example>
        public long Id { get; init; }

        /// <summary>
        ///     The unique name.
        /// </summary>
        /// <example>Adblock Plus</example>
        public required string Name { get; init; }

        /// <summary>
        ///     The description.
        /// </summary>
        /// <example>
        ///     Adblock Plus is a free extension that allows you to customize your web experience. You can block annoying ads,
        ///     disable tracking and lots more. It’s available for all major desktop browsers and for your mobile devices.
        /// </example>
        public string? Description { get; init; }

        /// <summary>
        ///     The URL of the home page.
        /// </summary>
        /// <example>https://adblockplus.org/</example>
        public Uri? HomeUrl { get; init; }

        /// <summary>
        ///     The URL of the Software download.
        /// </summary>
        /// <example>https://adblockplus.org/</example>
        public Uri? DownloadUrl { get; init; }

        /// <summary>
        ///     If the Software supports the abp: URL scheme to click-to-subscribe to a FilterList.
        /// </summary>
        /// <example>true</example>
        public bool SupportsAbpUrlScheme { get; init; }

        /// <summary>
        ///     The identifiers of the Syntaxes that this Software supports.
        /// </summary>
        /// <example>[ 3, 28, 38, 48 ]</example>
        public IEnumerable<short> SyntaxIds { get; init; } = [];
    }
}