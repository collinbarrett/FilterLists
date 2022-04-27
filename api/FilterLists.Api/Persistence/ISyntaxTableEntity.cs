using System;
using Azure.Data.Tables;

namespace FilterLists.Api.Persistence;

public interface ISyntaxTableEntity : ITableEntity
{
    //public string PartitionKey { get; init; } = TableStorageConstants.SyntaxesPartitionKey;
    //public long Id { get; init; } // RowKey

    public string Name { get; init; }
    public string? Description { get; init; }
    public Uri? Url { get; init; }
}