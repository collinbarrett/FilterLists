using System.Linq;
using FilterLists.Api.Infrastructure.Entities;

namespace FilterLists.Api.GetFilterListSummaries;

internal static class FilterListSummaryQueryProjection
{
    internal static IQueryable<FilterListSummary> ProjectToFilterListSummaries(this IQueryable<FilterList> filterLists)
    {
        return filterLists.Select(fl => new FilterListSummary
        {
            Id = fl.Id,
            Name = fl.Name,
            Description = fl.Description,
            LicenseId = fl.LicenseId,
            SyntaxIds = fl.FilterListSyntaxes
                .OrderBy(fls => fls.SyntaxId)
                .Select(fls => fls.SyntaxId),
            SoftwareIds = fl.FilterListSyntaxes
                .SelectMany(fls => fls.Syntax.SoftwareSyntaxes.Select(flss => flss.SoftwareId))
                .OrderBy(id => id)
                .Distinct(),
            LanguageIds = fl.FilterListLanguages
                .OrderBy(fll => fll.LanguageId)
                .Select(fll => fll.LanguageId),
            TagIds = fl.FilterListTags
                .OrderBy(flt => flt.TagId)
                .Select(flt => flt.TagId),
            MaintainerIds = fl.FilterListMaintainers
                .OrderBy(flm => flm.MaintainerId)
                .Select(flm => flm.MaintainerId)
        });
    }
}