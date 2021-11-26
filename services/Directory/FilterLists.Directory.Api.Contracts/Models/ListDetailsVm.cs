namespace FilterLists.Directory.Api.Contracts.Models;

public record ListDetailsVm
{
    public long Id { get; init; }
    public string Name { get; init; } = null!;
    public string? Description { get; init; }
    public long? LicenseId { get; init; }
    public IEnumerable<long> SyntaxIds { get; init; } = new HashSet<long>();
    public IEnumerable<long> LanguageIds { get; init; } = new HashSet<long>();
    public IEnumerable<long> TagIds { get; init; } = new HashSet<long>();
    public IEnumerable<ViewUrlVm> ViewUrls { get; init; } = new HashSet<ViewUrlVm>();
    public Uri? HomeUrl { get; init; }
    public Uri? OnionUrl { get; init; }
    public Uri? PolicyUrl { get; init; }
    public Uri? SubmissionUrl { get; init; }
    public Uri? IssuesUrl { get; init; }
    public Uri? ForumUrl { get; init; }
    public Uri? ChatUrl { get; init; }
    public string? EmailAddress { get; init; }
    public Uri? DonateUrl { get; init; }
    public IEnumerable<long> MaintainerIds { get; init; } = new HashSet<long>();
    public IEnumerable<long> UpstreamFilterListIds { get; init; } = new HashSet<long>();
    public IEnumerable<long> ForkFilterListIds { get; init; } = new HashSet<long>();
    public IEnumerable<long> IncludedInFilterListIds { get; init; } = new HashSet<long>();
    public IEnumerable<long> IncludesFilterListIds { get; init; } = new HashSet<long>();
    public IEnumerable<long> DependencyFilterListIds { get; init; } = new HashSet<long>();
    public IEnumerable<long> DependentFilterListIds { get; init; } = new HashSet<long>();

    public record ViewUrlVm
    {
        public short SegmentNumber { get; init; }
        public short Primariness { get; init; }
        public Uri Url { get; init; } = null!;
    }
}
