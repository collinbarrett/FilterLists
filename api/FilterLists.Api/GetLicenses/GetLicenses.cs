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

namespace FilterLists.Api.GetLicenses;

internal class GetLicenses
{
    private readonly IQueryContext _queryContext;

    public GetLicenses(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [OpenApiOperation(tags: "Licenses")]
    [OpenApiParameter(ODataExtensions.OrderByParamKey, Type = typeof(string), In = ParameterLocation.Query,
        Description = ODataExtensions.OrderByParamDescription)]
    [OpenApiParameter(ODataExtensions.SkipParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.SkipParamDescription)]
    [OpenApiParameter(ODataExtensions.TopParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.TopParamDescription)]
    [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(List<License>))]
    [FunctionName("GetLicenses")]
    public Task<List<License>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "licenses")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return _queryContext.Licenses
            .Select(l => new License
            {
                Id = l.Id,
                Name = l.Name,
                Url = l.Url,
                PermitsModification = l.PermitsModification,
                PermitsDistribution = l.PermitsDistribution,
                PermitsCommercialUse = l.PermitsCommercialUse,
                FilterListIds = l.FilterLists
                    .OrderBy(fl => fl.Id)
                    .Select(fl => fl.Id)
            }).OrderBy(l => l.Id)
            .ApplyODataOrderBy(req.Query)
            .ApplyODataSkip(req.Query)
            .ApplyODataTop(req.Query)
            .ToListAsync(cancellationToken);
    }
}