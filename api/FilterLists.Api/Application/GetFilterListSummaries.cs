using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Data.Tables;
using FilterLists.Api.Domain;
using FilterLists.Api.Extensions;
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
        private const int MaxDenormalizedSoftwareIndexCount = 22;
        private const int MaxDenormalizedSyntaxIndexCount = 4;
        private const int MaxDenormalizedLanguageIndexCount = 8;
        private const int MaxDenormalizedTagIndexCount = 10;
        private const int MaxDenormalizedMaintainerIndexCount = 4;

        private readonly IList<string> _languageIndices = Enumerable.Range(0, MaxDenormalizedLanguageIndexCount - 1)
            .Select(IntExtensions.ToIndexSuffix).ToList();
        private readonly IList<string> _maintainerIndices = Enumerable.Range(0, MaxDenormalizedMaintainerIndexCount - 1)
            .Select(IntExtensions.ToIndexSuffix).ToList();
        private readonly IList<string> _softwareIndices = Enumerable.Range(0, MaxDenormalizedSoftwareIndexCount - 1)
            .Select(IntExtensions.ToIndexSuffix).ToList();
        private readonly IList<string> _syntaxIndices = Enumerable.Range(0, MaxDenormalizedSyntaxIndexCount - 1)
            .Select(IntExtensions.ToIndexSuffix).ToList();
        private readonly IList<string> _tagIndices = Enumerable.Range(0, MaxDenormalizedTagIndexCount - 1)
            .Select(IntExtensions.ToIndexSuffix).ToList();

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
                nameof(IFilterListTableEntity.Description),
                nameof(IFilterListTableEntity.LicenseName)
            };

            select.AddRange(_softwareIndices.Select(i => $"{nameof(IFilterListTableEntity.SoftwareName)}{i}"));
            select.AddRange(_syntaxIndices.Select(i => $"{nameof(IFilterListTableEntity.SyntaxName)}{i}"));
            select.AddRange(_languageIndices.Select(i => $"{nameof(IFilterListTableEntity.LanguageIso6391)}{i}"));
            select.AddRange(_tagIndices.Select(i => $"{nameof(IFilterListTableEntity.TagName)}{i}"));
            select.AddRange(_maintainerIndices.Select(i => $"{nameof(IFilterListTableEntity.MaintainerName)}{i}"));

            return await _tableClient.QueryAsync<TableEntity>(select: select, cancellationToken: cancellationToken)
                .Select(te => new FilterListSummary
                {
                    Name = te.RowKey,
                    Description = te.GetString(nameof(IFilterListTableEntity.Description)),
                    Software = _softwareIndices
                        .Select(i => te.GetString($"{nameof(IFilterListTableEntity.SoftwareName)}{i}"))
                        .Where(s => s is not null),
                    Syntaxes = _syntaxIndices
                        .Select(i => te.GetString($"{nameof(IFilterListTableEntity.SyntaxName)}{i}"))
                        .Where(s => s is not null),
                    Languages = _languageIndices
                        .Select(i => te.GetString($"{nameof(IFilterListTableEntity.LanguageIso6391)}{i}"))
                        .Where(s => s is not null),
                    Tags = _tagIndices.Select(i => te.GetString($"{nameof(IFilterListTableEntity.TagName)}{i}"))
                        .Where(s => s is not null),
                    Maintainers = _maintainerIndices
                        .Select(i => te.GetString($"{nameof(IFilterListTableEntity.MaintainerName)}{i}"))
                        .Where(s => s is not null),
                    License = te.GetString(nameof(IFilterListTableEntity.LicenseName))
                }).ToListAsync(cancellationToken);
        }
    }

    public record FilterListSummary
    {
        public string Name { get; init; } = default!;
        public string? Description { get; init; }
        public IEnumerable<string> Software { get; init; } = new HashSet<string>();
        public IEnumerable<string> Syntaxes { get; init; } = new HashSet<string>();
        public IEnumerable<string> Languages { get; init; } = new HashSet<string>();
        public IEnumerable<string> Tags { get; init; } = new HashSet<string>();
        public IEnumerable<string> Maintainers { get; init; } = new HashSet<string>();
        public string License { get; init; } = default!;
    }
}