using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Data.Tables;
using MediatR;

namespace FilterLists.Api.Application;

public static class GetFilterListSummariesLight
{
    public record Query : IRequest<IEnumerable<FilterListSummaryLight>>
    {
    }

    public class Handler : IRequestHandler<Query, IEnumerable<FilterListSummaryLight>>
    {
        private readonly TableClient _tableClient;

        public Handler(TableServiceClient tableServiceClient)
        {
            _tableClient = tableServiceClient.GetTableClient(TableStorageConstants.FilterListsTableName);
        }

        public async Task<IEnumerable<FilterListSummaryLight>> Handle(Query request,
            CancellationToken cancellationToken)
        {
            return await _tableClient
                .QueryAsync<TableEntity>(
                    te => te.PartitionKey == TableStorageConstants.FilterListsPartitionKey,
                    select: new[] { nameof(TableEntity.RowKey) },
                    cancellationToken: cancellationToken)
                .Select(te => new FilterListSummaryLight { Name = te.RowKey })
                .ToListAsync(cancellationToken);
        }
    }

    public record FilterListSummaryLight
    {
        public string Name { get; init; } = default!;
    }
}