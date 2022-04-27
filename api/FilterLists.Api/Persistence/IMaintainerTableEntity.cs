using System;
using Azure.Data.Tables;

namespace FilterLists.Api.Persistence;

public interface IMaintainerTableEntity : ITableEntity
{
    //public string PartitionKey { get; init; } = TableStorageConstants.MaintainersPartitionKey;
    //public long Id { get; init; } // RowKey

    public string Name { get; init; }
    public Uri? Url { get; init; }
    public string? EmailAddress { get; init; }
    public string? TwitterHandle { get; init; }
}