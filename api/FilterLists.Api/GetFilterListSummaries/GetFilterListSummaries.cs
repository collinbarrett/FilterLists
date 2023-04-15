using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Infrastructure.Context;
using FilterLists.Api.Infrastructure.Entities;
using FilterLists.Api.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace FilterLists.Api.GetFilterListSummaries;

public class GetFilterListSummaries
{
    private readonly IQueryContext _queryContext;

    public GetFilterListSummaries(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [OpenApiOperation(tags: nameof(FilterList))]
    [OpenApiParameter(ODataExtensions.CountParamKey, Type = typeof(bool), In = ParameterLocation.Query,
        Description = ODataExtensions.CountParamDescription)]
    [OpenApiParameter(ODataExtensions.OrderByParamKey, Type = typeof(string), In = ParameterLocation.Query,
        Description = ODataExtensions.OrderByParamDescription)]
    [OpenApiParameter(ODataExtensions.SkipParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.SkipParamDescription)]
    [OpenApiParameter(ODataExtensions.TopParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.TopParamDescription)]
    [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(OData<List<FilterListSummary>>))]
    [FunctionName(nameof(GetFilterListSummaries))]
    public async Task<OData<List<FilterListSummary>>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "lists")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return new OData<List<FilterListSummary>>
        {
            Count = await _queryContext.FilterLists.ApplyODataCount(req.Query, cancellationToken),
            Value = await _queryContext.FilterLists
                .OrderBy(fl => fl.Id)
                .ApplyODataOrderBy(req.Query)
                .ApplyODataSkip(req.Query)
                .ApplyODataTop(req.Query)
                .ProjectToFilterListSummaries()
                .ToListAsync(cancellationToken)
        };
    }
}