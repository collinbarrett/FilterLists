using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace FilterLists.Api.GetFilterLists;

internal class GetFilterLists
{
    private readonly IQueryContext _queryContext;

    public GetFilterLists(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [OpenApiOperation(tags: "FilterLists")]
    [OpenApiParameter(ODataExtensions.OrderByParamKey, Type = typeof(string), In = ParameterLocation.Query,
        Description = ODataExtensions.OrderByParamDescription)]
    [OpenApiParameter(ODataExtensions.SkipParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.SkipParamDescription)]
    [OpenApiParameter(ODataExtensions.TopParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.TopParamDescription)]
    [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(List<FilterList>))]
    [FunctionName("GetFilterLists")]
    public Task<List<FilterList>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "lists")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return _queryContext.FilterLists
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
                MaintainerIds = fl.FilterListMaintainers
                    .OrderBy(flm => flm.MaintainerId)
                    .Select(flm => flm.MaintainerId)
            }).OrderBy(fl => fl.Id)
            .ApplyODataOrderBy(req.Query)
            .ApplyODataSkip(req.Query)
            .ApplyODataTop(req.Query)
            .ToListAsync(cancellationToken);
    }
}