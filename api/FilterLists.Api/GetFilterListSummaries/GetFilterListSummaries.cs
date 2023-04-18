using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Infrastructure.Context;
using FilterLists.Api.Infrastructure.Entities;
using FilterLists.Api.OData;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
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
    [OpenApiParameter(ODataExtensions.OrderByParamKey, Type = typeof(string), In = ParameterLocation.Query,
        Description = ODataExtensions.OrderByParamDescription)]
    [OpenApiParameter(ODataExtensions.SkipParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.SkipParamDescription)]
    [OpenApiParameter(ODataExtensions.TopParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.TopParamDescription)]
    [OpenApiParameter(ODataExtensions.CountParamKey, Type = typeof(bool), In = ParameterLocation.Query,
        Description = ODataExtensions.CountParamDescription)]
    [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(OData<List<FilterListSummary>>))]
    [Function(nameof(GetFilterListSummaries))]
    public async Task<OData<List<FilterListSummary>>> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "lists")] HttpRequestData req,
        CancellationToken cancellationToken)
    {
        return new OData<List<FilterListSummary>>
        {
            Value = await _queryContext.FilterLists
                .OrderBy(fl => fl.Id)
                // .ApplyODataOrderBy(req.Query)
                // .ApplyODataSkip(req.Query)
                // .ApplyODataTop(req.Query)
                .ProjectToFilterListSummaries()
                .ToListAsync(cancellationToken),
            // Count = await _queryContext.FilterLists.ApplyODataCount(req.Query, cancellationToken)
        };
    }
}