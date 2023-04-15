using System.Linq;
using FilterLists.Api.Infrastructure.Entities;

namespace FilterLists.Api.GetFilterListDetails;

internal static class FilterListDetailsQueryProjection
{
    internal static IQueryable<FilterListDetails> ProjectToFilterListDetails(this IQueryable<FilterList> filterLists)
    {
        return filterLists.Select(fl => new FilterListDetails
        {
            Id = fl.Id,
            Name = fl.Name,
            Description = fl.Description,
            LicenseId = fl.LicenseId,
            SyntaxIds = fl.FilterListSyntaxes
                .OrderBy(fls => fls.SyntaxId)
                .Select(fls => fls.SyntaxId),
            LanguageIds = fl.FilterListLanguages
                .OrderBy(fll => fll.LanguageId)
                .Select(fll => fll.LanguageId),
            TagIds = fl.FilterListTags.OrderBy(flt => flt.TagId)
                .Select(flt => flt.TagId),
            ViewUrls = fl.ViewUrls
                .OrderBy(u => u.SegmentNumber)
                .ThenBy(u => u.Primariness)
                .Select(u =>
                    new FilterListViewUrl
                    {
                        SegmentNumber = u.SegmentNumber,
                        Primariness = u.Primariness,
                        Url = u.Url
                    }),
            HomeUrl = fl.HomeUrl,
            OnionUrl = fl.OnionUrl,
            PolicyUrl = fl.PolicyUrl,
            SubmissionUrl = fl.SubmissionUrl,
            IssuesUrl = fl.IssuesUrl,
            ForumUrl = fl.ForumUrl,
            ChatUrl = fl.ChatUrl,
            EmailAddress = fl.EmailAddress,
            DonateUrl = fl.DonateUrl,
            MaintainerIds = fl.FilterListMaintainers
                .OrderBy(flm => flm.MaintainerId)
                .Select(flm => flm.MaintainerId),
            UpstreamFilterListIds = fl.UpstreamFilterLists.OrderBy(f => f.UpstreamFilterListId)
                .Select(f => f.UpstreamFilterListId),
            ForkFilterListIds = fl.ForkFilterLists
                .OrderBy(f => f.ForkFilterListId)
                .Select(f => f.ForkFilterListId),
            IncludedInFilterListIds = fl.IncludedInFilterLists
                .OrderBy(m => m.IncludedInFilterListId)
                .Select(m => m.IncludedInFilterListId),
            IncludesFilterListIds = fl.IncludesFilterLists
                .OrderBy(m => m.IncludesFilterListId)
                .Select(m => m.IncludesFilterListId),
            DependencyFilterListIds = fl.DependencyFilterLists
                .OrderBy(d => d.DependencyFilterListId)
                .Select(d => d.DependencyFilterListId),
            DependentFilterListIds = fl.DependentFilterLists
                .OrderBy(d => d.DependentFilterListId)
                .Select(d => d.DependentFilterListId)
        });
    }
}