namespace FilterLists.Directory.Domain.Aggregates;

public class FilterList
{
    public int Id { get; private set; }
    public string Name { get; private set; } = null!;
    public string? Description { get; private set; }
    public int? LicenseId { get; private set; }
    public Uri? HomeUrl { get; private set; }
    public Uri? OnionUrl { get; private set; }
    public Uri? PolicyUrl { get; private set; }
    public Uri? SubmissionUrl { get; private set; }
    public Uri? IssuesUrl { get; private set; }
    public Uri? ForumUrl { get; private set; }
    public Uri? ChatUrl { get; private set; }
    public string? EmailAddress { get; private set; }
    public Uri? DonateUrl { get; private set; }
}
