using FilterLists.Directory.Domain.Aggregates.Changes;
using FilterLists.Directory.Domain.Aggregates.Licenses;

namespace FilterLists.Directory.Domain.Aggregates.FilterLists;

public class FilterListCore : AggregateRootCore
{
    protected FilterListCore() { }

    public string Name { get; protected init; } = null!;
    public string? Description { get; protected init; }
    public License License { get; protected init; } = null!;
    public Uri? HomeUrl { get; protected init; }
    public Uri? OnionUrl { get; protected init; }
    public Uri? PolicyUrl { get; protected init; }
    public Uri? SubmissionUrl { get; protected init; }
    public Uri? IssuesUrl { get; protected init; }
    public Uri? ForumUrl { get; protected init; }
    public Uri? ChatUrl { get; protected init; }
    public string? EmailAddress { get; protected init; }
    public Uri? DonateUrl { get; protected init; }
    public IReadOnlyCollection<FilterListViewUrl> ViewUrls { get; protected init; } = new HashSet<FilterListViewUrl>();
}

public sealed class FilterList : FilterListCore, IRequireChangeApproval<FilterListChange>
{
    private ICollection<FilterListChange> _changes = new HashSet<FilterListChange>();

    private FilterList() { }

    public IReadOnlyCollection<FilterListChange> Changes => (IReadOnlyCollection<FilterListChange>)_changes;

    public static FilterList Create(
        string name,
        string? description,
        License license,
        Uri? homeUrl,
        Uri? onionUrl,
        Uri? policyUrl,
        Uri? submissionUrl,
        Uri? issuesUrl,
        Uri? forumUrl,
        Uri? chatUrl,
        string? emailAddress,
        Uri? donateUrl,
        IEnumerable<(short SegmentNumber, short Primariness, Uri Url)> viewUrls,
        string? createReason)
    {
        var urls = viewUrls.Select(u => FilterListViewUrl.Create(u.SegmentNumber, u.Primariness, u.Url))
            .ToList();
        if (urls.Count == 0)
        {
            throw new ArgumentException("At lest one view URL is required.", nameof(viewUrls));
        }

        var list = new FilterList
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
            ViewUrls = urls
        };
        list._changes = new HashSet<FilterListChange>(new[] { FilterListChange.Create(list, createReason) });
        return list;
    }
}
