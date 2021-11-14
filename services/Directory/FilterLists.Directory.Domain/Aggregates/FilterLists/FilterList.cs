using FilterLists.Directory.Domain.Aggregates.Licenses;

namespace FilterLists.Directory.Domain.Aggregates.FilterLists;

public class FilterList : IAggregate
{
    private FilterList()
    {
    }

    public string Name { get; private init; } = null!;
    public string? Description { get; private init; }
    public License? License { get; private init; }
    public Uri? HomeUrl { get; private init; }
    public Uri? OnionUrl { get; private init; }
    public Uri? PolicyUrl { get; private init; }
    public Uri? SubmissionUrl { get; private init; }
    public Uri? IssuesUrl { get; private init; }
    public Uri? ForumUrl { get; private init; }
    public Uri? ChatUrl { get; private init; }
    public string? EmailAddress { get; private init; }
    public Uri? DonateUrl { get; private init; }
    public IEnumerable<FilterListViewUrl> ViewUrls { get; init; } = new HashSet<FilterListViewUrl>();

    public static FilterList Create(
        string name,
        string? description,
        License? license,
        Uri? homeUrl,
        Uri? onionUrl,
        Uri? policyUrl,
        Uri? submissionUrl,
        Uri? issuesUrl,
        Uri? forumUrl,
        Uri? chatUrl,
        string? emailAddress,
        Uri? donateUrl,
        ICollection<FilterListViewUrl> viewUrls)
    {
        if (viewUrls.Count == 0)
        {
            // TODO: create and handle DomainExceptions
            throw new ArgumentException("At lest one view URL is required.", nameof(viewUrls));
        }

        return new FilterList
        {
            Name = name,
            Description = description,
            License = license,
            HomeUrl = homeUrl,
            OnionUrl = onionUrl,
            PolicyUrl = policyUrl,
            SubmissionUrl = submissionUrl,
            IssuesUrl = issuesUrl,
            ForumUrl = forumUrl,
            ChatUrl = chatUrl,
            EmailAddress = emailAddress,
            DonateUrl = donateUrl,
            ViewUrls = viewUrls
        };
    }
}
