using Azure.Data.Tables;

namespace FilterLists.Api.Persistence;

public interface ITagTableEntity : ITableEntity
{
    //public string PartitionKey { get; init; } = TableStorageConstants.TagsPartitionKey;
    //public long Id { get; init; } // RowKey

    public string Name { get; init; }
    public string? Description { get; init; }
}