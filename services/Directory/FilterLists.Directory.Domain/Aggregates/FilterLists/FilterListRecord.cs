using FilterLists.Directory.Domain.Aggregates.Licenses;

namespace FilterLists.Directory.Domain.Aggregates.FilterLists;

public record FilterListRecord(
    string Name,
    string? Description,
    License License,
    IReadOnlyCollection<FilterListViewUrl> ViewUrls,
    Uri? HomeUrl,
    Uri? OnionUrl,
    Uri? PolicyUrl,
    Uri? SubmissionUrl,
    Uri? IssuesUrl,
    Uri? ForumUrl,
    Uri? ChatUrl,
    string? EmailAddress,
    Uri? DonateUrl
)
{
    public static FilterListRecord FromFilterList(FilterList filterList)
    {
        return new FilterListRecord(
            filterList.Name,
            filterList.Description,
            filterList.License,
            filterList.ViewUrls,
            filterList.HomeUrl,
            filterList.OnionUrl,
            filterList.PolicyUrl,
            filterList.SubmissionUrl,
            filterList.IssuesUrl,
            filterList.ForumUrl,
            filterList.ChatUrl,
            filterList.EmailAddress,
            filterList.DonateUrl
        );
    }
}
