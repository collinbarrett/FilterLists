using FilterLists.Directory.Domain.Aggregates.Languages;
using FilterLists.Directory.Domain.Aggregates.Licenses;
using FilterLists.Directory.Domain.Aggregates.Maintainers;
using FilterLists.Directory.Domain.Aggregates.Syntaxes;
using FilterLists.Directory.Domain.Aggregates.Tags;
using FilterLists.Directory.Domain.Changes;
using FilterLists.SharedKernel.Domain.SeedWork;

namespace FilterLists.Directory.Domain.Aggregates.FilterLists;

public class FilterList : Entity, IRequireChangeApproval<FilterListChange>
{
    protected FilterList() { }

    public string Name { get; private init; } = default!;
    public string? Description { get; private init; }
    public virtual License License { get; private init; } = default!;
    public virtual IEnumerable<Syntax> Syntaxes { get; private init; } = new HashSet<Syntax>();
    public virtual IEnumerable<Language> Languages { get; private init; } = new HashSet<Language>();
    public virtual IEnumerable<Tag> Tags { get; private init; } = new HashSet<Tag>();
    public virtual IEnumerable<FilterListViewUrl> ViewUrls { get; private init; } = new HashSet<FilterListViewUrl>();
    public Uri? HomeUrl { get; private init; }
    public Uri? OnionUrl { get; private init; }
    public Uri? PolicyUrl { get; private init; }
    public Uri? SubmissionUrl { get; private init; }
    public Uri? IssuesUrl { get; private init; }
    public Uri? ForumUrl { get; private init; }
    public Uri? ChatUrl { get; private init; }
    public string? EmailAddress { get; private init; }
    public Uri? DonateUrl { get; private init; }
    public virtual IEnumerable<Maintainer> Maintainers { get; private init; } = new HashSet<Maintainer>();
    public virtual IEnumerable<FilterList> UpstreamFilterLists { get; private init; } = new HashSet<FilterList>();
    public virtual IEnumerable<FilterList> ForkFilterLists { get; private init; } = new HashSet<FilterList>();
    public virtual IEnumerable<FilterList> IncludedInFilterLists { get; private init; } = new HashSet<FilterList>();
    public virtual IEnumerable<FilterList> IncludesFilterLists { get; private init; } = new HashSet<FilterList>();
    public virtual IEnumerable<FilterList> DependencyFilterLists { get; private init; } = new HashSet<FilterList>();
    public virtual IEnumerable<FilterList> DependentFilterLists { get; private init; } = new HashSet<FilterList>();
    public virtual IEnumerable<FilterListChange> Changes { get; private set; } = new HashSet<FilterListChange>();
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
            Syntaxes = new HashSet<Syntax>(syntaxes),
            Languages = new HashSet<Language>(languages),
            Tags = new HashSet<Tag>(tags),
            ViewUrls = urls,
            HomeUrl = homeUrl,
            OnionUrl = onionUrl,
            PolicyUrl = policyUrl,
            SubmissionUrl = submissionUrl,
            IssuesUrl = issuesUrl,
            ForumUrl = forumUrl,
            ChatUrl = chatUrl,
            EmailAddress = emailAddress,
            DonateUrl = donateUrl,
            Maintainers = new HashSet<Maintainer>(maintainers),
            UpstreamFilterLists = upstreamFilterListSet,
            ForkFilterLists = forkFilterListSet,
            IncludedInFilterLists = includedInFilterListSet,
            IncludesFilterLists = includesFilterListSet,
            DependencyFilterLists = dependencyFilterListSet,
            DependentFilterLists = dependentFilterListSet,
            IsApproved = false
        };
        list.Changes = new HashSet<FilterListChange>(new[] { FilterListChange.Create(list, createReason) });
        return list;
    }
}
