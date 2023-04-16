using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Infrastructure.Context;
using FilterLists.Api.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace FilterLists.Api.GetMaintainers;

public class GetMaintainers
{
    private readonly IQueryContext _queryContext;

    public GetMaintainers(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [OpenApiOperation(tags: nameof(Infrastructure.Entities.Maintainer))]
    [OpenApiParameter(ODataExtensions.OrderByParamKey, Type = typeof(string), In = ParameterLocation.Query,
        Description = ODataExtensions.OrderByParamDescription)]
    [OpenApiParameter(ODataExtensions.SkipParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.SkipParamDescription)]
    [OpenApiParameter(ODataExtensions.TopParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.TopParamDescription)]
    [OpenApiParameter(ODataExtensions.CountParamKey, Type = typeof(bool), In = ParameterLocation.Query,
        Description = ODataExtensions.CountParamDescription)]
    [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(OData<List<Maintainer>>))]
    [FunctionName(nameof(GetMaintainers))]
    public async Task<OData<List<Maintainer>>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "maintainers")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return new OData<List<Maintainer>>
        {
            Value = await _queryContext.Maintainers
                .OrderBy(m => m.Id)
                .ApplyODataOrderBy(req.Query)
                .ApplyODataSkip(req.Query)
                .ApplyODataTop(req.Query)
                .ProjectToMaintainers()
                .ToListAsync(cancellationToken),
            Count = await _queryContext.Maintainers.ApplyODataCount(req.Query, cancellationToken)
        };
    }
}