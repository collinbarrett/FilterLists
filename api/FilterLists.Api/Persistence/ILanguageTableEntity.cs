using Azure.Data.Tables;

namespace FilterLists.Api.Persistence;

public interface ILanguageTableEntity : ITableEntity
{
    //public string PartitionKey { get; init; } = TableStorageConstants.LicensesPartitionKey;
    //public string Iso6391 { get; init; } // RowKey

    public string Name { get; init; }
}