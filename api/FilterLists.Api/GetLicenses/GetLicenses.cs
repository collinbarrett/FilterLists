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

namespace FilterLists.Api.GetLicenses;

internal class GetLicenses
{
    private readonly IQueryContext _queryContext;

    public GetLicenses(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [OpenApiOperation]
    [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(List<License>))]
    [FunctionName("GetLicenses")]
    public Task<List<License>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "licenses")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return _queryContext.Licenses
            .OrderBy(l => l.Id)
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
                }
            ).ToListAsync(cancellationToken);
    }
}