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
        private const int MaxDenormalizedLanguageIndexCount = 10; // 8 * 1.25
        private const int MaxDenormalizedMaintainerIndexCount = 5; // 4 * 1.25
        private const int MaxDenormalizedSoftwareIndexCount = 28; // 22 * 1.25
        private const int MaxDenormalizedSyntaxIndexCount = 7; // 5 * 1.25
        private const int MaxDenormalizedTagIndexCount = 13; // 10 * 1.25

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

            foreach (var i in _languageIndices)
            {
                select.Add($"{nameof(IFilterListTableEntity.LanguageIso6391)}{i}");
                select.Add($"{nameof(IFilterListTableEntity.LanguageName)}{i}");
            }

            select.AddRange(_maintainerIndices.Select(i => $"{nameof(IFilterListTableEntity.MaintainerName)}{i}"));
            select.AddRange(_softwareIndices.Select(i => $"{nameof(IFilterListTableEntity.SoftwareName)}{i}"));
            select.AddRange(_syntaxIndices.Select(i => $"{nameof(IFilterListTableEntity.SyntaxName)}{i}"));
            select.AddRange(_tagIndices.Select(i => $"{nameof(IFilterListTableEntity.TagName)}{i}"));

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
                    Languages = _languageIndices
                        .Where(l => te.ContainsKey($"{nameof(IFilterListTableEntity.LanguageIso6391)}{l}"))
                        .Select(l => new Language
                        {
                            Iso6391 = te.GetString($"{nameof(IFilterListTableEntity.LanguageIso6391)}{l}"),
                            Name = te.GetString($"{nameof(IFilterListTableEntity.LanguageName)}{l}")
                        }),
                    License = te.GetString(nameof(IFilterListTableEntity.LicenseName)),
                    Maintainers = _maintainerIndices
                        .Select(i => te.GetString($"{nameof(IFilterListTableEntity.MaintainerName)}{i}"))
                        .Where(s => s is not null),                    
                    Software = _softwareIndices
                        .Select(i => te.GetString($"{nameof(IFilterListTableEntity.SoftwareName)}{i}"))
                        .Where(s => s is not null),
                    Syntaxes = _syntaxIndices
                        .Select(i => te.GetString($"{nameof(IFilterListTableEntity.SyntaxName)}{i}"))
                        .Where(s => s is not null),
                    Tags = _tagIndices.Select(i => te.GetString($"{nameof(IFilterListTableEntity.TagName)}{i}"))
                        .Where(s => s is not null)
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
        public IEnumerable<string> Software { get; init; } = new HashSet<string>();
        public IEnumerable<string> Syntaxes { get; init; } = new HashSet<string>();
        public IEnumerable<string> Tags { get; init; } = new HashSet<string>();
    }

    public record Language
    {
        public string Iso6391 { get; init; } = default!;
        public string Name { get; init; } = default!;
    }
}