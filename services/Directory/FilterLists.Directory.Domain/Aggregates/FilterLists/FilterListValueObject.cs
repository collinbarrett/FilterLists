using FilterLists.SharedKernel.Domain.SeedWork;

namespace FilterLists.Directory.Domain.Aggregates.FilterLists;

public class FilterListValueObject : ValueObject
{
    public string Name { get; private init; } = default!;
    public string? Description { get; private init; }
    public long LicenseId { get; private init; }
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

    public static FilterListValueObject FromFilterList(FilterList filterList)
    {
        return new FilterListValueObject
        {
            Name = filterList.Name,
            Description = filterList.Description,
            LicenseId = filterList.License.Id,
            ViewUrlIds = filterList.ViewUrls.Select(u => u.Id),
            HomeUrl = filterList.HomeUrl,
            OnionUrl = filterList.OnionUrl,
            PolicyUrl = filterList.PolicyUrl,
            SubmissionUrl = filterList.SubmissionUrl,
            IssuesUrl = filterList.IssuesUrl,
            ForumUrl = filterList.ForumUrl,
            ChatUrl = filterList.ChatUrl,
            EmailAddress = filterList.EmailAddress,
            DonateUrl = filterList.DonateUrl
        };
    }

    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Name;
        yield return Description;
        yield return LicenseId;
        foreach (var viewUrlId in ViewUrlIds)
        {
            yield return viewUrlId;
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
    }
}
