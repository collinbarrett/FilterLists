using System;
using Azure.Data.Tables;

namespace FilterLists.Api.Persistence;

public interface ILicenseTableEntity : ITableEntity
{
    //public string PartitionKey { get; init; } = TableStorageConstants.LicensesPartitionKey;
    //public long Id { get; init; } // RowKey

    public string Name { get; init; }
    public Uri? Url { get; init; }
    public bool PermitsModification { get; init; }
    public bool PermitsDistribution { get; init; }
    public bool PermitsCommercialUse { get; init; }
}