using FilterLists.Directory.Domain.Aggregates.Changes;
using FilterLists.Directory.Domain.Aggregates.Licenses;

namespace FilterLists.Directory.Domain.Aggregates.FilterLists;

public sealed class FilterList : AggregateRoot, IRequireChangeApproval<FilterListChange>
{
    private readonly ICollection<FilterListChange> _changes = new HashSet<FilterListChange>();

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
    public IReadOnlyCollection<FilterListViewUrl> ViewUrls { get; private init; } = new HashSet<FilterListViewUrl>();

    public IReadOnlyCollection<FilterListChange> Changes
    {
        get => (IReadOnlyCollection<FilterListChange>)_changes;
        init => _changes = (ICollection<FilterListChange>)value;
    }

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
        ICollection<FilterListViewUrl> viewUrls,
        string? createReason)
    {
        if (viewUrls.Count == 0)
        {
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
            ViewUrls = (IReadOnlyCollection<FilterListViewUrl>)viewUrls,
            Changes = new HashSet<FilterListChange>(new[] { FilterListChange.Create(createReason) })
        };
    }
}
