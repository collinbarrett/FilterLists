using Azure.Data.Tables;

namespace FilterLists.Api.Domain;

public interface IFilterListTableEntity : ITableEntity
{
    //public string Name { get; init; } = default!; // RowKey
    public long Id { get; init; }
    public string? Description { get; init; }
    public string? HomeUrl { get; init; }
    public string? OnionUrl { get; init; }
    public string? PolicyUrl { get; init; }
    public string? SubmissionUrl { get; init; }
    public string? IssuesUrl { get; init; }
    public string? ForumUrl { get; init; }
    public string? ChatUrl { get; init; }
    public string? EmailAddress { get; init; }
    public string? DonateUrl { get; init; }

    public long LicenseId { get; init; }
    public string LicenseName { get; init; }
    public string? LicenseUrl { get; init; }
    public bool LicensePermitsModification { get; init; }
    public bool LicensePermitsDistribution { get; init; }
    public bool LicensePermitsCommercialUse { get; init; }

    public int ViewUrlSegmentNumber { get; init; }
    public int ViewUrlPrimariness { get; init; }
    public string ViewUrl { get; init; }

    public long? SyntaxId { get; init; }
    public string? SyntaxName { get; init; }
    public string? SyntaxDescription { get; init; }
    public string? SyntaxUrl { get; init; }

    public long? SoftwareId { get; init; }
    public string? SoftwareName { get; init; }
    public string? SoftwareDescription { get; init; }
    public string? SoftwareHomeUrl { get; init; }
    public string? SoftwareDownloadUrl { get; init; }
    public bool? SoftwareSupportsAbpUrlScheme { get; init; }

    public string? LanguageIso6391 { get; init; }

    public long? MaintainerId { get; init; }
    public string? MaintainerName { get; init; }
    public string? MaintainerUrl { get; init; }
    public string? MaintainerEmailAddress { get; init; }
    public string? MaintainerTwitterHandle { get; init; }

    public long? TagId { get; init; }
    public string? TagName { get; init; }
    public string? TagDescription { get; init; }

    public string? UpstreamFilterListName { get; init; }
    public string? ForkFilterListName { get; init; }
    public string? IncludedInFilterListName { get; init; }
    public string? IncludesFilterListName { get; init; }
    public string? DependencyFilterListName { get; init; }
    public string? DependentFilterListName { get; init; }
}