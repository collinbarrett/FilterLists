using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Data.Tables;
using FilterLists.Api.Extensions;
using FilterLists.Api.Persistence;
using MediatR;

namespace FilterLists.Api.Application;

public static class GetFilterListDetails
{
    public record Query : IRequest<IEnumerable<FilterListDetails>>
    {
        public long Id { get; init; }
    }

    public class Handler : IRequestHandler<Query, IEnumerable<FilterListDetails>>
    {
        // TODO: auto-increment or notify when these need to be manually incremented
        private const int MaxDenormalizedLanguageIndexCount = 10; // 8 * 1.25
        private const int MaxDenormalizedMaintainerIndexCount = 5; // 4 * 1.25
        private const int MaxDenormalizedSoftwareIndexCount = 28; // 22 * 1.25
        private const int MaxDenormalizedSyntaxIndexCount = 7; // 5 * 1.25
        private const int MaxDenormalizedTagIndexCount = 13; // 10 * 1.25
        private const int MaxDenormalizedViewUrlIndexCount = 10; // ? (TODO) * 1.25

        private readonly IList<string> _languageIndices = Enumerable.Range(0, MaxDenormalizedLanguageIndexCount - 1)
            .Select(Extensions.Extensions.ToIndexSuffix).ToList();

        private readonly IList<string> _maintainerIndices = Enumerable.Range(0, MaxDenormalizedMaintainerIndexCount - 1)
            .Select(Extensions.Extensions.ToIndexSuffix).ToList();

        private readonly IList<string> _softwareIndices = Enumerable.Range(0, MaxDenormalizedSoftwareIndexCount - 1)
            .Select(Extensions.Extensions.ToIndexSuffix).ToList();

        private readonly IList<string> _syntaxIndices = Enumerable.Range(0, MaxDenormalizedSyntaxIndexCount - 1)
            .Select(Extensions.Extensions.ToIndexSuffix).ToList();

        private readonly IList<string> _tagIndices = Enumerable.Range(0, MaxDenormalizedTagIndexCount - 1)
            .Select(Extensions.Extensions.ToIndexSuffix).ToList();

        private readonly IList<string> _viewUrlIndices = Enumerable.Range(0, MaxDenormalizedViewUrlIndexCount - 1)
            .Select(Extensions.Extensions.ToIndexSuffix).ToList();

        private readonly TableClient _tableClient;

        public Handler(TableServiceClient tableServiceClient)
        {
            _tableClient = tableServiceClient.GetTableClient(TableStorageConstants.FilterListsTableName);
        }

        public async Task<IEnumerable<FilterListDetails>> Handle(Query request, CancellationToken cancellationToken)
        {
            var select = new List<string>
            {
                nameof(IFilterListTableEntity.Name),
                nameof(IFilterListTableEntity.Description),
                nameof(IFilterListTableEntity.HomeUrl),
                nameof(IFilterListTableEntity.OnionUrl),
                nameof(IFilterListTableEntity.PolicyUrl),
                nameof(IFilterListTableEntity.SubmissionUrl),
                nameof(IFilterListTableEntity.IssuesUrl),
                nameof(IFilterListTableEntity.ForumUrl),
                nameof(IFilterListTableEntity.ChatUrl),
                nameof(IFilterListTableEntity.EmailAddress),
                nameof(IFilterListTableEntity.DonateUrl),
                nameof(IFilterListTableEntity.LicenseName),
                nameof(IFilterListTableEntity.LicenseUrl)
            };

            select.AddRange(_viewUrlIndices.Select(i => $"{nameof(IFilterListTableEntity.ViewUrlSegmentNumber)}{i}"));
            select.AddRange(_viewUrlIndices.Select(i => $"{nameof(IFilterListTableEntity.ViewUrlPrimariness)}{i}"));
            select.AddRange(_viewUrlIndices.Select(i => $"{nameof(IFilterListTableEntity.ViewUrl)}{i}"));

            //select.AddRange(_languageIndices.Select(i => $"{nameof(IFilterListTableEntity.LanguageIso6391)}{i}"));
            //select.AddRange(_maintainerIndices.Select(i => $"{nameof(IFilterListTableEntity.MaintainerName)}{i}"));
            //select.AddRange(_softwareIndices.Select(i => $"{nameof(IFilterListTableEntity.SoftwareName)}{i}"));
            //select.AddRange(_syntaxIndices.Select(i => $"{nameof(IFilterListTableEntity.SyntaxName)}{i}"));
            //select.AddRange(_tagIndices.Select(i => $"{nameof(IFilterListTableEntity.TagName)}{i}"));

            return await _tableClient.QueryAsync<TableEntity>(
                    te => te.PartitionKey == TableStorageConstants.FilterListsPartitionKey && te.RowKey == request.Id.ToTableStorageKeyString(),
                    select: select,
                    cancellationToken: cancellationToken)
                .Select(te => new TableEntity(te.Where(kv => kv.Value is not null).ToDictionary(kv => kv.Key, kv => kv.Value)))
                .Select(te => new FilterListDetails
                {
                    Id = request.Id,
                    Name = te.GetString(nameof(IFilterListTableEntity.Name)),
                    Description = te.GetString(nameof(IFilterListTableEntity.Description)),
                    HomeUrl = te.GetString(nameof(IFilterListTableEntity.HomeUrl)),
                    OnionUrl = te.GetString(nameof(IFilterListTableEntity.OnionUrl)),
                    PolicyUrl = te.GetString(nameof(IFilterListTableEntity.PolicyUrl)),
                    SubmissionUrl = te.GetString(nameof(IFilterListTableEntity.SubmissionUrl)),
                    IssuesUrl = te.GetString(nameof(IFilterListTableEntity.IssuesUrl)),
                    ForumUrl = te.GetString(nameof(IFilterListTableEntity.ForumUrl)),
                    ChatUrl = te.GetString(nameof(IFilterListTableEntity.ChatUrl)),
                    EmailAddress = te.GetString(nameof(IFilterListTableEntity.EmailAddress)),
                    DonateUrl = te.GetString(nameof(IFilterListTableEntity.DonateUrl)),
                    ViewUrls = _viewUrlIndices
                        .Where(u => te.ContainsKey($"{nameof(IFilterListTableEntity.ViewUrl)}{u}"))
                        .Select(u => new FilterListViewUrl
                        {
                            Url = te.GetString($"{nameof(IFilterListTableEntity.ViewUrl)}{u}"),
                            Primariness = (int)te.GetInt32($"{nameof(IFilterListTableEntity.ViewUrlPrimariness)}{u}")!,
                            SegmentNumber = (int)te.GetInt32($"{nameof(IFilterListTableEntity.ViewUrlSegmentNumber)}{u}")!
                        }),
                    //Languages = _languageIndices
                    //    .Select(i => te.GetString($"{nameof(IFilterListTableEntity.LanguageIso6391)}{i}"))
                    //    .Where(s => s is not null),
                    License = new License
                    {
                        Name = te.GetString(nameof(IFilterListTableEntity.LicenseName)),
                        Url = te.GetString(nameof(IFilterListTableEntity.LicenseUrl))
                    },
                    //Maintainers = _maintainerIndices
                    //    .Select(i => te.GetString($"{nameof(IFilterListTableEntity.MaintainerName)}{i}"))
                    //    .Where(s => s is not null)
                    //Software = _softwareIndices
                    //    .Select(i => te.GetString($"{nameof(IFilterListTableEntity.SoftwareName)}{i}"))
                    //    .Where(s => s is not null),
                    //Syntaxes = _syntaxIndices
                    //    .Select(i => te.GetString($"{nameof(IFilterListTableEntity.SyntaxName)}{i}"))
                    //    .Where(s => s is not null),
                    //Tags = _tagIndices.Select(i => te.GetString($"{nameof(IFilterListTableEntity.TagName)}{i}"))
                    //    .Where(s => s is not null)
                }).ToListAsync(cancellationToken);
        }
    }

    public record FilterListDetails
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
        public string? HomeUrl { get; init; }
        public string? OnionUrl { get; init; }
        public string? PolicyUrl { get; init; }
        public string? SubmissionUrl { get; init; }
        public string? IssuesUrl { get; init; }
        public string? ForumUrl { get; init; }
        public string? ChatUrl { get; init; }
        public string? EmailAddress { get; init; }
        public string? DonateUrl { get; init; }
        public IEnumerable<FilterListViewUrl> ViewUrls { get; init; } = new HashSet<FilterListViewUrl>();
        public IEnumerable<string> LanguageIso6391s { get; init; } = new HashSet<string>();
        public License License { get; init; } = default!;
        public IEnumerable<Maintainer> Maintainers { get; init; } = new HashSet<Maintainer>();
        public IEnumerable<Syntax> Syntaxes { get; init; } = new HashSet<Syntax>();
        public IEnumerable<Tag> Tags { get; init; } = new HashSet<Tag>();
        public IEnumerable<string> UpstreamFilterListNames { get; init; } = new HashSet<string>();
        public IEnumerable<string> ForkFilterListNames { get; init; } = new HashSet<string>();
        public IEnumerable<string> IncludedInFilterListNames { get; init; } = new HashSet<string>();
        public IEnumerable<string> IncludesFilterListNames { get; init; } = new HashSet<string>();
        public IEnumerable<string> DependencyFilterListNames { get; init; } = new HashSet<string>();
        public IEnumerable<string> DependentFilterListNames { get; init; } = new HashSet<string>();
    }

    public record FilterListViewUrl
    {
        public int SegmentNumber { get; init; }
        public int Primariness { get; init; }
        public string Url { get; init; } = default!;
    }

    public record License
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
        public string? Url { get; init; }
        public bool PermitsModification { get; init; }
        public bool PermitsDistribution { get; init; }
        public bool PermitsCommercialUse { get; init; }
    }

    public record Maintainer
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
        public string? Url { get; init; }
        public string? EmailAddress { get; init; }
        public string? TwitterHandle { get; init; }
    }

    public record Syntax
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
        public string? Url { get; init; }
        public IEnumerable<Software> Software { get; init; } = new HashSet<Software>();
    }

    public record Software
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
        public string? HomeUrl { get; init; }
        public string? DownloadUrl { get; init; }
        public bool SupportsAbpUrlScheme { get; init; }
    }

    public record Tag
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
    }
}