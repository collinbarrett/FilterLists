using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Api.GetFilterLists;

internal class GetFilterLists
{
    private readonly IQueryContext _queryContext;

    public GetFilterLists(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [FunctionName("GetFilterLists")]
    public Task<List<FilterList>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "lists")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return _queryContext.FilterLists
            .OrderBy(fl => fl.Id)
            .Select(fl => new FilterList
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
                TagIds = fl.FilterListTags
                    .OrderBy(flt => flt.TagId)
                    .Select(flt => flt.TagId),
                PrimaryViewUrl = fl.ViewUrls
                    .OrderBy(u => u.SegmentNumber)
                    .ThenBy(u => u.Primariness)
                    .Select(u => u.Url)
                    .FirstOrDefault(),
                MaintainerIds = fl.FilterListMaintainers
                    .OrderBy(flm => flm.MaintainerId)
                    .Select(flm => flm.MaintainerId)
            }).ToListAsync(cancellationToken);
    }
}