namespace FilterLists.Directory.Api.Contracts.Models;

public class ListDetailsVm
{
    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public string? Description { get; init; }
    public int? LicenseId { get; init; }
    public IEnumerable<int>? SyntaxIds { get; init; }
    public IEnumerable<string>? Iso6391s { get; init; }
    public IEnumerable<int>? TagIds { get; init; }
    public IEnumerable<ViewUrlVm>? ViewUrls { get; init; }
    public Uri? HomeUrl { get; init; }
    public Uri? OnionUrl { get; init; }
    public Uri? PolicyUrl { get; init; }
    public Uri? SubmissionUrl { get; init; }
    public Uri? IssuesUrl { get; init; }
    public Uri? ForumUrl { get; init; }
    public Uri? ChatUrl { get; init; }
    public string? EmailAddress { get; init; }
    public Uri? DonateUrl { get; init; }
    public IEnumerable<int>? MaintainerIds { get; init; }
    public IEnumerable<int>? UpstreamFilterListIds { get; init; }
    public IEnumerable<int>? ForkFilterListIds { get; init; }
    public IEnumerable<int>? IncludedInFilterListIds { get; init; }
    public IEnumerable<int>? IncludesFilterListIds { get; init; }
    public IEnumerable<int>? DependencyFilterListIds { get; init; }
    public IEnumerable<int>? DependentFilterListIds { get; init; }

    public class ViewUrlVm
    {
        public short SegmentNumber { get; init; }
        public short Primariness { get; init; }
        public Uri Url { get; init; } = null!;
    }
}
