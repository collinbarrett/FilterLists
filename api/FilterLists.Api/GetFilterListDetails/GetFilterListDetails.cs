using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Infrastructure.Context;
using FilterLists.Api.Infrastructure.Entities;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
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

    [OpenApiOperation(tags: nameof(FilterList))]
    [OpenApiParameter(nameof(FilterList.Id), Required = true, Type = typeof(int))]
    [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(FilterListDetails))]
    [Function(nameof(GetFilterListDetails))]
    public async Task<FilterListDetails?> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "lists/{id:int}")]
        HttpRequestData req,
        int id,
        CancellationToken cancellationToken)
    {
        return await _queryContext.FilterLists
            .Where(f => f.Id == id)
            .ProjectToFilterListDetails()
            .FirstOrDefaultAsync(cancellationToken);
    }
}