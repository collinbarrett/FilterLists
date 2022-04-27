using System;
using Azure.Data.Tables;

namespace FilterLists.Api.Persistence;

public interface IFilterListTableEntity : ITableEntity
{
    //public string PartitionKey { get; init; } = TableStorageConstants.FilterListsPartitionKey;
    //public long Id { get; init; } // RowKey

    public string Name { get; init; }
    public string? Description { get; init; }
    public Uri? HomeUrl { get; init; }
    public Uri? OnionUrl { get; init; }
    public Uri? PolicyUrl { get; init; }
    public Uri? SubmissionUrl { get; init; }
    public Uri? IssuesUrl { get; init; }
    public Uri? ForumUrl { get; init; }
    public Uri? ChatUrl { get; init; }
    public string? EmailAddress { get; init; }
    public Uri? DonateUrl { get; init; }

    // 1-of-n suffixed w/'_XX'
    public int ViewUrlSegmentNumber { get; init; }
    public int ViewUrlPrimariness { get; init; }
    public Uri ViewUrl { get; init; }

    // 1-of-n suffixed w/'_XX'
    public string? LanguageIso6391 { get; init; }
    public string? LanguageName { get; init; }

    public long LicenseId { get; init; }
    public string LicenseName { get; init; }
    public Uri? LicenseUrl { get; init; }
    public bool LicensePermitsModification { get; init; }
    public bool LicensePermitsDistribution { get; init; }
    public bool LicensePermitsCommercialUse { get; init; }

    // 1-of-n suffixed w/'_XX'
    public long? MaintainerId { get; init; }
    public string? MaintainerName { get; init; }
    public Uri? MaintainerUrl { get; init; }
    public string? MaintainerEmailAddress { get; init; }
    public string? MaintainerTwitterHandle { get; init; }

    // 1-of-n suffixed w/'_XX'
    public long? SyntaxId { get; init; }
    public string? SyntaxName { get; init; }
    public string? SyntaxDescription { get; init; }
    public Uri? SyntaxUrl { get; init; }

    // 1-of-n suffixed w/'_XX'
    public long? SoftwareId { get; init; }
    public string? SoftwareName { get; init; }

    // 1-of-n suffixed w/'_XX'
    public long? TagId { get; init; }
    public string? TagName { get; init; }
    public string? TagDescription { get; init; }

    // 1-of-n suffixed w/'_XX'
    public long? UpstreamFilterListId { get; init; }
    public string? UpstreamFilterListName { get; init; }

    // 1-of-n suffixed w/'_XX'
    public long? ForkFilterListId { get; init; }
    public string? ForkFilterListName { get; init; }

    // 1-of-n suffixed w/'_XX'
    public long? IncludedInFilterListId { get; init; }
    public string? IncludedInFilterListName { get; init; }

    // 1-of-n suffixed w/'_XX'
    public long? IncludesFilterListId { get; init; }
    public string? IncludesFilterListName { get; init; }

    // 1-of-n suffixed w/'_XX'
    public long? DependencyFilterListId { get; init; }
    public string? DependencyFilterListName { get; init; }

    // 1-of-n suffixed w/'_XX'
    public long? DependentFilterListId { get; init; }
    public string? DependentFilterListName { get; init; }
}