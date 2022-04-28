using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Data.Tables;
using FilterLists.Api.Persistence;
using MediatR;

namespace FilterLists.Api.Application;

public static class GetFilterListSummaries
{
    public record Query : IRequest<IEnumerable<FilterListSummary>>
    {
    }

    public class Handler : IRequestHandler<Query, IEnumerable<FilterListSummary>>
    {
        // TODO: auto-increment or notify when these need to be manually incremented
        private const int MaxDenormalizedLanguageIndexCount = 12; // 8 * 1.5
        private const int MaxDenormalizedMaintainerIndexCount = 6; // 4 * 1.5
        private const int MaxDenormalizedSoftwareIndexCount = 33; // 22 * 1.5
        private const int MaxDenormalizedSyntaxIndexCount = 8; // 5 * 1.5
        private const int MaxDenormalizedTagIndexCount = 15; // 10 * 1.5

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

        private readonly TableClient _tableClient;

        public Handler(TableServiceClient tableServiceClient)
        {
            _tableClient = tableServiceClient.GetTableClient(TableStorageConstants.FilterListsTableName);
        }

        public async Task<IEnumerable<FilterListSummary>> Handle(Query request, CancellationToken cancellationToken)
        {
            var select = new List<string>
            {
                nameof(TableEntity.RowKey),
                nameof(IFilterListTableEntity.Name),
                nameof(IFilterListTableEntity.Description),
                nameof(IFilterListTableEntity.LicenseName)
            };

            foreach (var li in _languageIndices)
            {
                select.Add(nameof(IFilterListTableEntity.LanguageIso6391) + li);
                select.Add(nameof(IFilterListTableEntity.LanguageName) + li);
            }

            select.AddRange(_maintainerIndices.Select(mi => nameof(IFilterListTableEntity.MaintainerName) + mi));

            foreach (var si in _softwareIndices)
            {
                select.Add(nameof(IFilterListTableEntity.SoftwareId) + si);
                select.Add(nameof(IFilterListTableEntity.SoftwareName) + si);
            }

            foreach (var si in _syntaxIndices)
            {
                select.Add(nameof(IFilterListTableEntity.SyntaxName) + si);
                select.Add(nameof(IFilterListTableEntity.SyntaxDescription) + si);
            }

            foreach (var ti in _tagIndices)
            {
                select.Add(nameof(IFilterListTableEntity.TagName) + ti);
                select.Add(nameof(IFilterListTableEntity.TagDescription) + ti);
            }

            return await _tableClient.QueryAsync<TableEntity>(
                    te => te.PartitionKey == TableStorageConstants.FilterListsPartitionKey,
                    select: select,
                    cancellationToken: cancellationToken)
                .Select(te => new TableEntity(te.Where(kv => kv.Value is not null).ToDictionary(kv => kv.Key, kv => kv.Value)))
                .Select(te => new FilterListSummary
                {
                    Id = te.RowKey.FromTableStorageKeyString(),
                    Name = te.GetString(nameof(IFilterListTableEntity.Name)),
                    Description = te.GetString(nameof(IFilterListTableEntity.Description)),
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
                    License = te.GetString(nameof(IFilterListTableEntity.LicenseName)),
                    Maintainers = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.MaintainerName) + '_'))
                        .Select((_, mi) => te.GetString(nameof(IFilterListTableEntity.MaintainerName) + mi.ToIndexSuffix()))
                        .OrderBy(m => m),
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
                    Syntaxes = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.SyntaxName) + '_'))
                        .Select((_, si) =>
                        {
                            var indexSuffix = si.ToIndexSuffix();
                            return new Syntax
                            {
                                Name = te.GetString(nameof(IFilterListTableEntity.SyntaxName) + indexSuffix),
                                Description = te.GetString(nameof(IFilterListTableEntity.SyntaxDescription) + indexSuffix)
                            };
                        })
                        .OrderBy(s => s.Name),
                    Tags = te.Where(kv => kv.Key.StartsWith(nameof(IFilterListTableEntity.TagName) + '_'))
                        .Select((_, ti) =>
                        {
                            var indexSuffix = ti.ToIndexSuffix();
                            return new Tag
                            {
                                Name = te.GetString(nameof(IFilterListTableEntity.TagName) + indexSuffix),
                                Description = te.GetString(nameof(IFilterListTableEntity.TagDescription) + indexSuffix)
                            };
                        })
                        .OrderBy(t => t.Name),
                })
                .OrderBy(l => l.Name)
                .ToListAsync(cancellationToken);
        }
    }

    public record FilterListSummary
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
        public IEnumerable<Language> Languages { get; init; } = new HashSet<Language>();
        public string License { get; init; } = default!;
        public IEnumerable<string> Maintainers { get; init; } = new HashSet<string>();
        public IEnumerable<Software> Software { get; init; } = new HashSet<Software>();
        public IEnumerable<Syntax> Syntaxes { get; init; } = new HashSet<Syntax>();
        public IEnumerable<Tag> Tags { get; init; } = new HashSet<Tag>();
    }

    public record Language
    {
        public string Iso6391 { get; init; } = default!;
        public string Name { get; init; } = default!;
    }

    public record Software
    {
        public long Id { get; init; }
        public string Name { get; init; } = default!;
    }

    public record Syntax
    {
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
    }

    public record Tag
    {
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
    }
}