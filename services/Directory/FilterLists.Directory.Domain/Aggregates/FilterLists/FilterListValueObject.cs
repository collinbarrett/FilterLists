using FilterLists.SharedKernel.Domain.SeedWork;

namespace FilterLists.Directory.Domain.Aggregates.FilterLists;

public class FilterListValueObject : ValueObject
{
    public string Name { get; private init; } = default!;
    public string? Description { get; private init; }
    public long LicenseId { get; private init; }
    public IEnumerable<long> SyntaxIds { get; private init; } = new HashSet<long>();
    public IEnumerable<long> LanguageIds { get; private init; } = new HashSet<long>();
    public IEnumerable<long> TagIds { get; private init; } = new HashSet<long>();
    public IEnumerable<long> ViewUrlIds { get; private init; } = new HashSet<long>();
    public Uri? HomeUrl { get; private init; }
    public Uri? OnionUrl { get; private init; }
    public Uri? PolicyUrl { get; private init; }
    public Uri? SubmissionUrl { get; private init; }
    public Uri? IssuesUrl { get; private init; }
    public Uri? ForumUrl { get; private init; }
    public Uri? ChatUrl { get; private init; }
    public string? EmailAddress { get; private init; }
    public Uri? DonateUrl { get; private init; }
    public IEnumerable<long> MaintainerIds { get; private init; } = new HashSet<long>();
    public IEnumerable<long> UpstreamFilterListIds { get; private init; } = new HashSet<long>();
    public IEnumerable<long> ForkFilterListIds { get; private init; } = new HashSet<long>();
    public IEnumerable<long> IncludedInFilterListIds { get; private init; } = new HashSet<long>();
    public IEnumerable<long> IncludesFilterListIds { get; private init; } = new HashSet<long>();
    public IEnumerable<long> DependencyFilterListIds { get; private init; } = new HashSet<long>();
    public IEnumerable<long> DependentFilterListIds { get; private init; } = new HashSet<long>();

    public static FilterListValueObject FromFilterList(FilterList filterList)
    {
        return new FilterListValueObject
        {
            Name = filterList.Name,
            Description = filterList.Description,
            LicenseId = filterList.License.Id,
            SyntaxIds = filterList.Syntaxes.Select(s => s.Id),
            LanguageIds = filterList.Languages.Select(l => l.Id),
            TagIds = filterList.Tags.Select(t => t.Id),
            ViewUrlIds = filterList.ViewUrls.Select(u => u.Id),
            HomeUrl = filterList.HomeUrl,
            OnionUrl = filterList.OnionUrl,
            PolicyUrl = filterList.PolicyUrl,
            SubmissionUrl = filterList.SubmissionUrl,
            IssuesUrl = filterList.IssuesUrl,
            ForumUrl = filterList.ForumUrl,
            ChatUrl = filterList.ChatUrl,
            EmailAddress = filterList.EmailAddress,
            DonateUrl = filterList.DonateUrl,
            MaintainerIds = filterList.Maintainers.Select(m => m.Id),
            UpstreamFilterListIds = filterList.UpstreamFilterLists.Select(f => f.Id),
            ForkFilterListIds = filterList.ForkFilterLists.Select(f => f.Id),
            IncludedInFilterListIds = filterList.IncludedInFilterLists.Select(f => f.Id),
            IncludesFilterListIds = filterList.IncludesFilterLists.Select(f => f.Id),
            DependencyFilterListIds = filterList.DependencyFilterLists.Select(f => f.Id),
            DependentFilterListIds = filterList.DependentFilterLists.Select(f => f.Id)
        };
    }

    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Name;
        yield return Description;
        yield return LicenseId;
        foreach (var id in SyntaxIds)
        {
            yield return id;
        }

        foreach (var id in LanguageIds)
        {
            yield return id;
        }

        foreach (var id in TagIds)
        {
            yield return id;
        }

        foreach (var id in ViewUrlIds)
        {
            yield return id;
        }

        yield return HomeUrl;
        yield return OnionUrl;
        yield return PolicyUrl;
        yield return SubmissionUrl;
        yield return IssuesUrl;
        yield return ForumUrl;
        yield return ChatUrl;
        yield return EmailAddress;
        yield return DonateUrl;
        foreach (var id in MaintainerIds)
        {
            yield return id;
        }

        foreach (var id in UpstreamFilterListIds)
        {
            yield return id;
        }

        foreach (var id in ForkFilterListIds)
        {
            yield return id;
        }

        foreach (var id in IncludedInFilterListIds)
        {
            yield return id;
        }

        foreach (var id in IncludesFilterListIds)
        {
            yield return id;
        }

        foreach (var id in DependencyFilterListIds)
        {
            yield return id;
        }

        foreach (var id in DependentFilterListIds)
        {
            yield return id;
        }
    }
}
