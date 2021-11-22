using FilterLists.Directory.Domain.Aggregates.Changes;
using FilterLists.Directory.Domain.Aggregates.Licenses;

namespace FilterLists.Directory.Domain.Aggregates.FilterLists;

public class FilterList : IRequireChangeApproval<FilterListChange>
{
    private ICollection<FilterListChange> _changes = new HashSet<FilterListChange>();

    protected FilterList() { }

    public string Name { get; private init; } = null!;
    public string? Description { get; private init; }
    public virtual License License { get; private init; } = null!;
    public virtual IReadOnlyCollection<FilterListViewUrl> ViewUrls { get; private init; } = new HashSet<FilterListViewUrl>();
    public Uri? HomeUrl { get; private init; }
    public Uri? OnionUrl { get; private init; }
    public Uri? PolicyUrl { get; private init; }
    public Uri? SubmissionUrl { get; private init; }
    public Uri? IssuesUrl { get; private init; }
    public Uri? ForumUrl { get; private init; }
    public Uri? ChatUrl { get; private init; }
    public string? EmailAddress { get; private init; }
    public Uri? DonateUrl { get; private init; }
    public virtual IReadOnlyCollection<FilterListChange> Changes => (IReadOnlyCollection<FilterListChange>)_changes;
    public bool IsApproved { get; private init; }

    public static FilterList CreatePendingApproval(
        string name,
        string? description,
        License license,
        IEnumerable<(short SegmentNumber, short Primariness, Uri Url)> viewUrls,
        Uri? homeUrl,
        Uri? onionUrl,
        Uri? policyUrl,
        Uri? submissionUrl,
        Uri? issuesUrl,
        Uri? forumUrl,
        Uri? chatUrl,
        string? emailAddress,
        Uri? donateUrl,
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
            ViewUrls = urls,
            IsApproved = false
        };
        list._changes = new HashSet<FilterListChange>(new[] { FilterListChange.Create(list, createReason) });
        return list;
    }
}
