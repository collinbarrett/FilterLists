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

namespace FilterLists.Api.GetMaintainers;

internal class GetMaintainers
{
    private readonly IQueryContext _queryContext;

    public GetMaintainers(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [OpenApiOperation(tags: "Maintainers")]
    [OpenApiParameter(ODataExtensions.OrderByParamKey, Type = typeof(string), In = ParameterLocation.Query,
        Description = ODataExtensions.OrderByParamDescription)]
    [OpenApiParameter(ODataExtensions.SkipParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.SkipParamDescription)]
    [OpenApiParameter(ODataExtensions.TopParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.TopParamDescription)]
    [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(List<Maintainer>))]
    [FunctionName("GetMaintainers")]
    public Task<List<Maintainer>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "maintainers")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return _queryContext.Maintainers
            .Select(m => new Maintainer
            {
                Id = m.Id,
                Name = m.Name,
                Url = m.Url,
                EmailAddress = m.EmailAddress,
                TwitterHandle = m.TwitterHandle,
                FilterListIds = m.FilterListMaintainers
                    .OrderBy(flm => flm.FilterListId)
                    .Select(flm => flm.FilterListId)
            }).OrderBy(m => m.Id)
            .ApplyODataOrderBy(req.Query)
            .ApplyODataSkip(req.Query)
            .ApplyODataTop(req.Query)
            .ToListAsync(cancellationToken);
    }
}