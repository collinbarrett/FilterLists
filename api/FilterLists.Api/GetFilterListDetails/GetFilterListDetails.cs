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

namespace FilterLists.Api.GetFilterListDetails;

public class GetFilterListDetails
{
    private readonly IQueryContext _queryContext;

    public GetFilterListDetails(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [OpenApiOperation(tags: "FilterLists")]
    [OpenApiParameter("id", Required = true, Type = typeof(int))]
    [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(FilterListDetails))]
    [FunctionName("GetFilterListDetails")]
    public Task<FilterListDetails?> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "lists/{id:int}")]
        HttpRequest req,
        int id,
        CancellationToken cancellationToken)
    {
        return _queryContext.FilterLists
            .Where(f => f.Id == id)
            .ProjectToFilterListDetails()
            .SingleOrDefaultAsync(cancellationToken);
    }
}