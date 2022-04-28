using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Data.Tables;
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
            .Select(Extensions.ToIndexSuffix).ToList();

        private readonly IList<string> _maintainerIndices = Enumerable.Range(0, MaxDenormalizedMaintainerIndexCount - 1)
            .Select(Extensions.ToIndexSuffix).ToList();

        private readonly IList<string> _softwareIndices = Enumerable.Range(0, MaxDenormalizedSoftwareIndexCount - 1)
            .Select(Extensions.ToIndexSuffix).ToList();

        private readonly IList<string> _syntaxIndices = Enumerable.Range(0, MaxDenormalizedSyntaxIndexCount - 1)
            .Select(Extensions.ToIndexSuffix).ToList();

        private readonly IList<string> _tagIndices = Enumerable.Range(0, MaxDenormalizedTagIndexCount - 1)
            .Select(Extensions.ToIndexSuffix).ToList();

        private readonly IList<string> _viewUrlIndices = Enumerable.Range(0, MaxDenormalizedViewUrlIndexCount - 1)
            .Select(Extensions.ToIndexSuffix).ToList();

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
                nameof(IFilterListTableEntity.LicenseId),
                nameof(IFilterListTableEntity.LicenseName),
                nameof(IFilterListTableEntity.LicenseUrl),
                nameof(IFilterListTableEntity.LicensePermitsModification),
                nameof(IFilterListTableEntity.LicensePermitsDistribution),
                nameof(IFilterListTableEntity.LicensePermitsCommercialUse)
            };

            foreach (var ui in _viewUrlIndices)
            {
                select.Add(nameof(IFilterListTableEntity.ViewUrlSegmentNumber) + ui);
                select.Add(nameof(IFilterListTableEntity.ViewUrlPrimariness) + ui);
                select.Add(nameof(IFilterListTableEntity.ViewUrl) + ui);
            }

            foreach (var li in _languageIndices)
            {
                select.Add(nameof(IFilterListTableEntity.LanguageIso6391) + li);
                select.Add(nameof(IFilterListTableEntity.LanguageName) + li);
            }

            foreach (var mi in _maintainerIndices)
            {
                select.Add(nameof(IFilterListTableEntity.MaintainerId) + mi);
                select.Add(nameof(IFilterListTableEntity.MaintainerName) + mi);
                select.Add(nameof(IFilterListTableEntity.MaintainerUrl) + mi);
                select.Add(nameof(IFilterListTableEntity.MaintainerEmailAddress) + mi);
                select.Add(nameof(IFilterListTableEntity.MaintainerTwitterHandle) + mi);
            }

            foreach (var si in _softwareIndices)
            {
                select.Add(nameof(IFilterListTableEntity.SoftwareId) + si);
                select.Add(nameof(IFilterListTableEntity.SoftwareName) + si);
            }

            foreach (var si in _syntaxIndices)
            {
                select.Add(nameof(IFilterListTableEntity.SyntaxId) + si);
                select.Add(nameof(IFilterListTableEntity.SyntaxName) + si);
                select.Add(nameof(IFilterListTableEntity.SyntaxDescription) + si);
                select.Add(nameof(IFilterListTableEntity.SyntaxUrl) + si);
            }

            foreach (var ti in _tagIndices)
            {
                select.Add(nameof(IFilterListTableEntity.TagId) + ti);
                select.Add(nameof(IFilterListTableEntity.TagName) + ti);
                select.Add(nameof(IFilterListTableEntity.TagDescription) + ti);
            }

            return await _tableClient.QueryAsync<TableEntity>(
                    te => te.PartitionKey == TableStorageConstants.FilterListsPartitionKey &&
                          te.RowKey == request.Id.ToTableStorageKeyString(),
                    select: select,
                    cancellationToken: cancellationToken)
                .Select(te => new TableEntity(te.Where(kv => kv.Value is not null).ToDictionary(kv => kv.Key, kv => kv.Value)))
                .Select(te => new FilterListDetails
                {
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
                        .Where(ui => te.ContainsKey(nameof(IFilterListTableEntity.ViewUrl) + ui))
                        .Select(ui => new FilterListViewUrl
                        {
                            SegmentNumber = (int)te.GetInt32(nameof(IFilterListTableEntity.ViewUrlSegmentNumber) + ui)!,
                            Primariness = (int)te.GetInt32(nameof(IFilterListTableEntity.ViewUrlPrimariness) + ui)!,
                            Url = te.GetString(nameof(IFilterListTableEntity.ViewUrl) + ui)
                        })
                        .OrderBy(u => u.SegmentNumber)
                        .ThenBy(u => u.Primariness),
                    Languages = _languageIndices
                        .Where(li => te.ContainsKey(nameof(IFilterListTableEntity.LanguageIso6391) + li))
                        .Select(li => new Language
                        {
                            Iso6391 = te.GetString(nameof(IFilterListTableEntity.LanguageIso6391) + li),
                            Name = te.GetString(nameof(IFilterListTableEntity.LanguageName) + li)
                        })
                        .OrderBy(l => l.Iso6391),
                    License = new License
                    {
                        Id = (long)te.GetInt64(nameof(IFilterListTableEntity.LicenseId))!,
                        Name = te.GetString(nameof(IFilterListTableEntity.LicenseName)),
                        Url = te.GetString(nameof(IFilterListTableEntity.LicenseUrl)),
                        PermitsModification = (bool)te.GetBoolean(nameof(IFilterListTableEntity.LicensePermitsModification))!,
                        PermitsDistribution = (bool)te.GetBoolean(nameof(IFilterListTableEntity.LicensePermitsDistribution))!,
                        PermitsCommercialUse = (bool)te.GetBoolean(nameof(IFilterListTableEntity.LicensePermitsCommercialUse))!
                    },
                    Maintainers = _maintainerIndices
                        .Where(mi => te.ContainsKey(nameof(IFilterListTableEntity.MaintainerId) + mi))
                        .Select(mi => new Maintainer
                        {
                            Id = (long)te.GetInt64(nameof(IFilterListTableEntity.MaintainerId) + mi)!,
                            Name = te.GetString(nameof(IFilterListTableEntity.MaintainerName) + mi),
                            Url = te.GetString(nameof(IFilterListTableEntity.MaintainerUrl) + mi),
                            EmailAddress = te.GetString(nameof(IFilterListTableEntity.MaintainerEmailAddress) + mi),
                            TwitterHandle = te.GetString(nameof(IFilterListTableEntity.MaintainerTwitterHandle) + mi)
                        })
                        .OrderBy(m => m.Name),
                    Software = _softwareIndices
                        .Where(si => te.ContainsKey(nameof(IFilterListTableEntity.SoftwareId) + si))
                        .Select(si => new Software
                        {
                            Id = (long)te.GetInt64(nameof(IFilterListTableEntity.SoftwareId) + si)!,
                            Name = te.GetString(nameof(IFilterListTableEntity.SoftwareName) + si)
                        })
                        .OrderBy(s => s.Name),
                    Syntaxes = _syntaxIndices
                        .Where(si => te.ContainsKey(nameof(IFilterListTableEntity.SyntaxId) + si))
                        .Select(si => new Syntax
                        {
                            Id = (long)te.GetInt64(nameof(IFilterListTableEntity.SyntaxId) + si)!,
                            Name = te.GetString(nameof(IFilterListTableEntity.SyntaxName) + si),
                            Description = te.GetString(nameof(IFilterListTableEntity.SyntaxDescription) + si),
                            Url = te.GetString(nameof(IFilterListTableEntity.SyntaxUrl) + si)
                        })
                        .OrderBy(s => s.Name),
                    Tags = _tagIndices
                        .Where(ti => te.ContainsKey(nameof(IFilterListTableEntity.TagId) + ti))
                        .Select(ti => new Tag
                        {
                            Id = (long)te.GetInt64(nameof(IFilterListTableEntity.TagId) + ti)!,
                            Name = te.GetString(nameof(IFilterListTableEntity.TagName) + ti),
                            Description = te.GetString(nameof(IFilterListTableEntity.TagDescription) + ti)
                        })
                        .OrderBy(t => t.Name)
                }).ToListAsync(cancellationToken);
        }
    }

    public record FilterListDetails
    {
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
        public IEnumerable<Language> Languages { get; init; } = new HashSet<Language>();
        public License License { get; init; } = default!;
        public IEnumerable<Maintainer> Maintainers { get; init; } = new HashSet<Maintainer>();
        public IEnumerable<Software> Software { get; init; } = new HashSet<Software>();
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

    public record Language
    {
        public string Iso6391 { get; init; } = default!;
        public string Name { get; init; } = default!;
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

    public record Software
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
    }

    public record Syntax
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
        public string? Url { get; init; }
    }

    public record Tag
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
    }
}