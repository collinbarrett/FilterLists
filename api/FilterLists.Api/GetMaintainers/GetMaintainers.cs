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

namespace FilterLists.Api.GetMaintainers;

internal class GetMaintainers
{
    private readonly IQueryContext _queryContext;

    public GetMaintainers(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [OpenApiOperation]
    [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(List<Maintainer>))]
    [FunctionName("GetMaintainers")]
    public Task<List<Maintainer>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "maintainers")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return _queryContext.Maintainers
            .OrderBy(m => m.Id)
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
            }).ToListAsync(cancellationToken);
    }
}