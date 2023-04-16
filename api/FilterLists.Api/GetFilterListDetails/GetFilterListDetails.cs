using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Infrastructure.Context;
using FilterLists.Api.Infrastructure.Entities;
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

    [OpenApiOperation(tags: nameof(FilterList))]
    [OpenApiParameter(nameof(FilterList.Id), Required = true, Type = typeof(int))]
    [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(FilterListDetails))]
    [FunctionName(nameof(GetFilterListDetails))]
    public Task<FilterListDetails?> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "lists/{id:int}")]
        HttpRequest req,
        int id,
        CancellationToken cancellationToken)
    {
        return _queryContext.FilterLists
            .Where(f => f.Id == id)
            .ProjectToFilterListDetails()
            .FirstOrDefaultAsync(cancellationToken);
    }
}