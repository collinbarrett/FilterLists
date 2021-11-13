namespace FilterLists.Directory.Api.Contracts.Models;

public record ListDetailsVm
{
    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public string? Description { get; init; }
    public int? LicenseId { get; init; }
    public IReadOnlyCollection<int> SyntaxIds { get; init; } = new HashSet<int>();
    public IReadOnlyCollection<string> Iso6391s { get; init; } = new HashSet<string>();
    public IReadOnlyCollection<int> TagIds { get; init; } = new HashSet<int>();
    public IReadOnlyCollection<ViewUrlVm> ViewUrls { get; init; } = new HashSet<ViewUrlVm>();
    public Uri? HomeUrl { get; init; }
    public Uri? OnionUrl { get; init; }
    public Uri? PolicyUrl { get; init; }
    public Uri? SubmissionUrl { get; init; }
    public Uri? IssuesUrl { get; init; }
    public Uri? ForumUrl { get; init; }
    public Uri? ChatUrl { get; init; }
    public string? EmailAddress { get; init; }
    public Uri? DonateUrl { get; init; }
    public IReadOnlyCollection<int> MaintainerIds { get; init; } = new HashSet<int>();
    public IReadOnlyCollection<int> UpstreamFilterListIds { get; init; } = new HashSet<int>();
    public IReadOnlyCollection<int> ForkFilterListIds { get; init; } = new HashSet<int>();
    public IReadOnlyCollection<int> IncludedInFilterListIds { get; init; } = new HashSet<int>();
    public IReadOnlyCollection<int> IncludesFilterListIds { get; init; } = new HashSet<int>();
    public IReadOnlyCollection<int> DependencyFilterListIds { get; init; } = new HashSet<int>();
    public IReadOnlyCollection<int> DependentFilterListIds { get; init; } = new HashSet<int>();

    public record ViewUrlVm
    {
        public short SegmentNumber { get; init; }
        public short Primariness { get; init; }
        public Uri Url { get; init; } = null!;
    }
}
