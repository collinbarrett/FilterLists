using FilterLists.Directory.Domain.Aggregates.Licenses;

namespace FilterLists.Directory.Domain.Aggregates.FilterLists;

public record FilterListRecord(
    string Name,
    string? Description,
    License License,
    Uri? HomeUrl,
    Uri? OnionUrl,
    Uri? PolicyUrl,
    Uri? SubmissionUrl,
    Uri? IssuesUrl,
    Uri? ForumUrl,
    Uri? ChatUrl,
    string? EmailAddress,
    Uri? DonateUrl,
    IReadOnlyCollection<FilterListViewUrl> ViewUrls)
{
    public static FilterListRecord FromFilterList(FilterList filterList)
    {
        return new FilterListRecord(
            filterList.Name,
            filterList.Description,
            filterList.License,
            filterList.HomeUrl,
            filterList.OnionUrl,
            filterList.PolicyUrl,
            filterList.SubmissionUrl,
            filterList.IssuesUrl,
            filterList.ForumUrl,
            filterList.ChatUrl,
            filterList.EmailAddress,
            filterList.DonateUrl,
            filterList.ViewUrls);
    }
}
