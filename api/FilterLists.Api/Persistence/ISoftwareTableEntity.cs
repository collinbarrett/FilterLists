using System;
using Azure.Data.Tables;

namespace FilterLists.Api.Persistence;

public interface ISoftwareTableEntity : ITableEntity
{
    //public string PartitionKey { get; init; } = TableStorageConstants.SoftwarePartitionKey;
    //public long Id { get; init; } // RowKey

    public string Name { get; init; }
    public string? Description { get; init; }
    public Uri? HomeUrl { get; init; }
    public Uri? DownloadUrl { get; init; }
    public bool? SupportsAbpUrlScheme { get; init; }
}

public interface ISoftwareSyntaxTableEntity : ITableEntity
{
    //public string PartitionKey { get; init; } = TableStorageConstants.SoftwarePartitionKey;
    //public long SoftwareId_SyntaxId { get; init; } // RowKey

    public string SyntaxName { get; init; }
    public string? SyntaxDescription { get; init; }
    public Uri? SyntaxUrl { get; init; }
}