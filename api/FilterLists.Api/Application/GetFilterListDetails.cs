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
    public record Query : IRequest<FilterListDetails?>
    {
        public long Id { get; init; }
    }

    public class Handler : IRequestHandler<Query, FilterListDetails?>
    {
        private readonly TableClient _tableClient;

        public Handler(TableServiceClient tableServiceClient)
        {
            _tableClient = tableServiceClient.GetTableClient(TableStorageConstants.FilterListsTableName);
        }

        public async Task<FilterListDetails?> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _tableClient.QueryAsync<TableEntity>(
                    te => te.PartitionKey == TableStorageConstants.FilterListsPartitionKey &&
                          te.RowKey == request.Id.ToTableStorageKeyString(),
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
                    ViewUrls = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.ViewUrl) + '_'))
                        .Select((_, ui) =>
                        {
                            var indexSuffix = ui.ToIndexSuffix();
                            return new FilterListViewUrl
                            {
                                SegmentNumber = (int)te.GetInt32(nameof(IFilterListTableEntity.ViewUrlSegmentNumber) + indexSuffix)!,
                                Primariness = (int)te.GetInt32(nameof(IFilterListTableEntity.ViewUrlPrimariness) + indexSuffix)!,
                                Url = te.GetString(nameof(IFilterListTableEntity.ViewUrl) + indexSuffix)
                            };
                        })
                        .OrderBy(u => u.SegmentNumber)
                        .ThenBy(u => u.Primariness),
                    Languages = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.LanguageIso6391) + '_'))
                        .Select((_, li) =>
                        {
                            var indexSuffix = li.ToIndexSuffix();
                            return new Language
                            {
                                Iso6391 = te.GetString(nameof(IFilterListTableEntity.LanguageIso6391) + indexSuffix),
                                Name = te.GetString(nameof(IFilterListTableEntity.LanguageName) + indexSuffix)
                            };
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
                    Maintainers = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.MaintainerId) + '_'))
                        .Select((_, mi) =>
                        {
                            var indexSuffix = mi.ToIndexSuffix();
                            return new Maintainer
                            {
                                Id = (long)te.GetInt64(nameof(IFilterListTableEntity.MaintainerId) + indexSuffix)!,
                                Name = te.GetString(nameof(IFilterListTableEntity.MaintainerName) + indexSuffix),
                                Url = te.GetString(nameof(IFilterListTableEntity.MaintainerUrl) + indexSuffix),
                                EmailAddress = te.GetString(nameof(IFilterListTableEntity.MaintainerEmailAddress) + indexSuffix),
                                TwitterHandle = te.GetString(nameof(IFilterListTableEntity.MaintainerTwitterHandle) + indexSuffix)
                            };
                        })
                        .OrderBy(m => m.Name),
                    Software = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.SoftwareId) + '_'))
                        .Select((_, si) =>
                        {
                            var indexSuffix = si.ToIndexSuffix();
                            return new Software
                            {
                                Id = (long)te.GetInt64(nameof(IFilterListTableEntity.SoftwareId) + indexSuffix)!,
                                Name = te.GetString(nameof(IFilterListTableEntity.SoftwareName) + indexSuffix)
                            };
                        })
                        .OrderBy(s => s.Name),
                    Syntaxes = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.SyntaxId) + '_'))
                        .Select((_, si) =>
                        {
                            var indexSuffix = si.ToIndexSuffix();
                            return new Syntax
                            {
                                Id = (long)te.GetInt64(nameof(IFilterListTableEntity.SyntaxId) + indexSuffix)!,
                                Name = te.GetString(nameof(IFilterListTableEntity.SyntaxName) + indexSuffix),
                                Description = te.GetString(nameof(IFilterListTableEntity.SyntaxDescription) + indexSuffix),
                                Url = te.GetString(nameof(IFilterListTableEntity.SyntaxUrl) + indexSuffix)
                            };
                        })
                        .OrderBy(s => s.Name),
                    Tags = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.TagId) + '_'))
                        .Select((_, ti) =>
                        {
                            var indexSuffix = ti.ToIndexSuffix();
                            return new Tag
                            {
                                Id = (long)te.GetInt64(nameof(IFilterListTableEntity.TagId) + indexSuffix)!,
                                Name = te.GetString(nameof(IFilterListTableEntity.TagName) + indexSuffix),
                                Description = te.GetString(nameof(IFilterListTableEntity.TagDescription) + indexSuffix)
                            };
                        })
                        .OrderBy(t => t.Name),
                    UpstreamFilterListNames = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.UpstreamFilterListId) + '_'))
                        .Select((_, fi) =>
                        {
                            var indexSuffix = fi.ToIndexSuffix();
                            return new RelatedFilterList
                            {
                                Id = (long)te.GetInt64(nameof(IFilterListTableEntity.UpstreamFilterListId) + indexSuffix)!,
                                Name = te.GetString(nameof(IFilterListTableEntity.UpstreamFilterListName) + indexSuffix)
                            };
                        })
                        .OrderBy(ufl => ufl.Name),
                    ForkFilterListNames = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.ForkFilterListId) + '_'))
                        .Select((_, fi) =>
                        {
                            var indexSuffix = fi.ToIndexSuffix();
                            return new RelatedFilterList
                            {
                                Id = (long)te.GetInt64(nameof(IFilterListTableEntity.ForkFilterListId) + indexSuffix)!,
                                Name = te.GetString(nameof(IFilterListTableEntity.ForkFilterListName) + indexSuffix)
                            };
                        })
                        .OrderBy(ffl => ffl.Name),
                    IncludedInFilterListNames = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.IncludedInFilterListId) + '_'))
                        .Select((_, mi) =>
                        {
                            var indexSuffix = mi.ToIndexSuffix();
                            return new RelatedFilterList
                            {
                                Id = (long)te.GetInt64(nameof(IFilterListTableEntity.IncludedInFilterListId) + indexSuffix)!,
                                Name = te.GetString(nameof(IFilterListTableEntity.IncludedInFilterListName) + indexSuffix)
                            };
                        })
                        .OrderBy(iifl => iifl.Name),
                    IncludesFilterListNames = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.IncludesFilterListId) + '_'))
                        .Select((_, mi) =>
                        {
                            var indexSuffix = mi.ToIndexSuffix();
                            return new RelatedFilterList
                            {
                                Id = (long)te.GetInt64(nameof(IFilterListTableEntity.IncludesFilterListId) + indexSuffix)!,
                                Name = te.GetString(nameof(IFilterListTableEntity.IncludesFilterListName) + indexSuffix)
                            };
                        })
                        .OrderBy(ifl => ifl.Name),
                    DependencyFilterListNames = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.DependencyFilterListId) + '_'))
                        .Select((_, di) =>
                        {
                            var indexSuffix = di.ToIndexSuffix();
                            return new RelatedFilterList
                            {
                                Id = (long)te.GetInt64(nameof(IFilterListTableEntity.DependencyFilterListId) + indexSuffix)!,
                                Name = te.GetString(nameof(IFilterListTableEntity.DependencyFilterListName) + indexSuffix)
                            };
                        })
                        .OrderBy(dfl => dfl.Name),
                    DependentFilterListNames = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.DependentFilterListId) + '_'))
                        .Select((_, di) =>
                        {
                            var indexSuffix = di.ToIndexSuffix();
                            return new RelatedFilterList
                            {
                                Id = (long)te.GetInt64(nameof(IFilterListTableEntity.DependentFilterListId) + indexSuffix)!,
                                Name = te.GetString(nameof(IFilterListTableEntity.DependentFilterListName) + indexSuffix)
                            };
                        })
                        .OrderBy(dfl => dfl.Name)
                }).FirstOrDefaultAsync(cancellationToken);
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
        public IEnumerable<RelatedFilterList> UpstreamFilterListNames { get; init; } = new HashSet<RelatedFilterList>();
        public IEnumerable<RelatedFilterList> ForkFilterListNames { get; init; } = new HashSet<RelatedFilterList>();
        public IEnumerable<RelatedFilterList> IncludedInFilterListNames { get; init; } = new HashSet<RelatedFilterList>();
        public IEnumerable<RelatedFilterList> IncludesFilterListNames { get; init; } = new HashSet<RelatedFilterList>();
        public IEnumerable<RelatedFilterList> DependencyFilterListNames { get; init; } = new HashSet<RelatedFilterList>();
        public IEnumerable<RelatedFilterList> DependentFilterListNames { get; init; } = new HashSet<RelatedFilterList>();
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

    public record RelatedFilterList
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
    }
}