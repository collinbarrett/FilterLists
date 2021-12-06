using FilterLists.Directory.Domain.Aggregates.Languages;
using FilterLists.Directory.Domain.Aggregates.Licenses;
using FilterLists.Directory.Domain.Aggregates.Maintainers;
using FilterLists.Directory.Domain.Aggregates.Syntaxes;
using FilterLists.Directory.Domain.Aggregates.Tags;
using FilterLists.Directory.Domain.Changes;
using FilterLists.Directory.Domain.ValueObjects;
using FilterLists.SharedKernel.Domain.SeedWork;

namespace FilterLists.Directory.Domain.Aggregates.FilterLists;

public class FilterList : Entity, IRequireChangeApproval<FilterListChange>
{
    private readonly ICollection<FilterListChange> _changes = new HashSet<FilterListChange>();
    private readonly ICollection<FilterList> _dependencyFilterLists = new HashSet<FilterList>();
    private readonly ICollection<FilterList> _dependentFilterLists = new HashSet<FilterList>();
    private readonly ICollection<FilterList> _forkFilterLists = new HashSet<FilterList>();
    private readonly ICollection<FilterList> _includedInFilterLists = new HashSet<FilterList>();
    private readonly ICollection<FilterList> _includesFilterLists = new HashSet<FilterList>();
    private readonly ICollection<Language> _languages = new HashSet<Language>();
    private readonly ICollection<Maintainer> _maintainers = new HashSet<Maintainer>();
    private readonly ICollection<Syntax> _syntaxes = new HashSet<Syntax>();
    private readonly ICollection<Tag> _tags = new HashSet<Tag>();
    private readonly ICollection<FilterList> _upstreamFilterLists = new HashSet<FilterList>();
    private readonly ICollection<FilterListViewUrl> _viewUrls = new HashSet<FilterListViewUrl>();

    protected FilterList() { }

    public string Name { get; private init; } = default!;
    public string? Description { get; private init; }
    public virtual License License { get; private init; } = default!;

    public virtual IEnumerable<Syntax> Syntaxes
    {
        get => _syntaxes;
        private init => _syntaxes = new HashSet<Syntax>(value);
    }

    public virtual IEnumerable<Language> Languages
    {
        get => _languages;
        private init => _languages = new HashSet<Language>(value);
    }

    public virtual IEnumerable<Tag> Tags
    {
        get => _tags;
        private init => _tags = new HashSet<Tag>(value);
    }

    public virtual IEnumerable<FilterListViewUrl> ViewUrls
    {
        get => _viewUrls;
        private init => _viewUrls = new HashSet<FilterListViewUrl>(value);
    }

    public Uri? HomeUrl { get; private init; }
    public OnionUrl? OnionUrl { get; private init; }
    public Uri? PolicyUrl { get; private init; }
    public Uri? SubmissionUrl { get; private init; }
    public Uri? IssuesUrl { get; private init; }
    public Uri? ForumUrl { get; private init; }
    public Uri? ChatUrl { get; private init; }
    public string? EmailAddress { get; private init; }
    public Uri? DonateUrl { get; private init; }

    public virtual IEnumerable<Maintainer> Maintainers
    {
        get => _maintainers;
        private init => _maintainers = new HashSet<Maintainer>(value);
    }

    public virtual IEnumerable<FilterList> UpstreamFilterLists
    {
        get => _upstreamFilterLists;
        private init => _upstreamFilterLists = new HashSet<FilterList>(value);
    }

    public virtual IEnumerable<FilterList> ForkFilterLists
    {
        get => _forkFilterLists;
        private init => _forkFilterLists = new HashSet<FilterList>(value);
    }

    public virtual IEnumerable<FilterList> IncludedInFilterLists
    {
        get => _includedInFilterLists;
        private init => _includedInFilterLists = new HashSet<FilterList>(value);
    }

    public virtual IEnumerable<FilterList> IncludesFilterLists
    {
        get => _includesFilterLists;
        private init => _includesFilterLists = new HashSet<FilterList>(value);
    }

    public virtual IEnumerable<FilterList> DependencyFilterLists
    {
        get => _dependencyFilterLists;
        private init => _dependencyFilterLists = new HashSet<FilterList>(value);
    }

    public virtual IEnumerable<FilterList> DependentFilterLists
    {
        get => _dependentFilterLists;
        private init => _dependentFilterLists = new HashSet<FilterList>(value);
    }

    public virtual IEnumerable<FilterListChange> Changes => _changes;
    public bool IsApproved { get; private init; }

    public static FilterList CreatePendingApproval(
        string name,
        string? description,
        License license,
        IEnumerable<Syntax> syntaxes,
        IEnumerable<Language> languages,
        IEnumerable<Tag> tags,
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
        IEnumerable<Maintainer> maintainers,
        IEnumerable<FilterList> upstreamFilterLists,
        IEnumerable<FilterList> forkFilterLists,
        IEnumerable<FilterList> includedInFilterLists,
        IEnumerable<FilterList> includesFilterLists,
        IEnumerable<FilterList> dependencyFilterLists,
        IEnumerable<FilterList> dependentFilterLists,
        string? createReason)
    {
        var urls = viewUrls.DistinctBy(u => new { u.SegmentNumber, u.Primariness, u.Url })
            .Select(u => FilterListViewUrl.Create(u.SegmentNumber, u.Primariness, u.Url))
            .ToList();
        if (urls.Count == 0)
        {
            throw new ArgumentException("At lest one view URL is required.", nameof(viewUrls));
        }

        if (urls.GroupBy(u => new { u.SegmentNumber, u.Primariness }).Any(g => g.Count() > 1))
        {
            throw new ArgumentException("The segment number and primariness pair must be unique for each view URL.", nameof(viewUrls));
        }

        var upstreamFilterListSet = new HashSet<FilterList>(upstreamFilterLists);
        var forkFilterListSet = new HashSet<FilterList>(forkFilterLists);
        if (upstreamFilterListSet.Intersect(forkFilterListSet).Any())
        {
            throw new ArgumentException("A FilterList cannot be both an Upstream and a Fork of the same FilterList.");
        }

        var includedInFilterListSet = new HashSet<FilterList>(includedInFilterLists);
        var includesFilterListSet = new HashSet<FilterList>(includesFilterLists);
        if (includedInFilterListSet.Intersect(includesFilterListSet).Any())
        {
            throw new ArgumentException("A FilterList cannot be both included in and including of the same FilterList.");
        }

        var dependencyFilterListSet = new HashSet<FilterList>(dependencyFilterLists);
        var dependentFilterListSet = new HashSet<FilterList>(dependentFilterLists);
        if (dependencyFilterListSet.Intersect(dependentFilterListSet).Any())
        {
            throw new ArgumentException("A FilterList cannot be both a dependency of and dependent upon the same FilterList.");
        }

        var list = new FilterList
        {
            Name = name,
            Description = description,
            License = license,
            Syntaxes = syntaxes,
            Languages = languages,
            Tags = tags,
            ViewUrls = urls,
            HomeUrl = homeUrl,
            OnionUrl = onionUrl is null ? default : new OnionUrl(onionUrl),
            PolicyUrl = policyUrl,
            SubmissionUrl = submissionUrl,
            IssuesUrl = issuesUrl,
            ForumUrl = forumUrl,
            ChatUrl = chatUrl,
            EmailAddress = emailAddress,
            DonateUrl = donateUrl,
            Maintainers = maintainers,
            UpstreamFilterLists = upstreamFilterListSet,
            ForkFilterLists = forkFilterListSet,
            IncludedInFilterLists = includedInFilterListSet,
            IncludesFilterLists = includesFilterListSet,
            DependencyFilterLists = dependencyFilterListSet,
            DependentFilterLists = dependentFilterListSet,
            IsApproved = false
        };
        list._changes.Add(FilterListChange.Create(list, createReason));
        return list;
    }
}
