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
    [OpenApiParameter(ODataExtensions.CountParamKey, Type = typeof(bool), In = ParameterLocation.Query,
        Description = ODataExtensions.CountParamDescription)]
    [OpenApiParameter(ODataExtensions.OrderByParamKey, Type = typeof(string), In = ParameterLocation.Query,
        Description = ODataExtensions.OrderByParamDescription)]
    [OpenApiParameter(ODataExtensions.SkipParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.SkipParamDescription)]
    [OpenApiParameter(ODataExtensions.TopParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.TopParamDescription)]
    [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(OData<List<License>>))]
    [FunctionName("GetLicenses")]
    public async Task<OData<List<License>>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "licenses")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return new OData<List<License>>
        {
            Count = await _queryContext.Licenses.ApplyODataCount(req.Query, cancellationToken),
            Value = await _queryContext.Licenses
                .Select(l => new License
                {
                    Id = l.Id,
                    Name = l.Name,
                    Url = l.Url,
                    PermitsModification = l.PermitsModification,
                    PermitsDistribution = l.PermitsDistribution,
                    PermitsCommercialUse = l.PermitsCommercialUse
                }).OrderBy(l => l.Id)
                .ApplyODataOrderBy(req.Query)
                .ApplyODataSkip(req.Query)
                .ApplyODataTop(req.Query)
                .ToListAsync(cancellationToken)
        };
    }
}