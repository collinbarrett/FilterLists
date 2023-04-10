using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Api.GetTags;

internal class GetTags
{
    private readonly IQueryContext _queryContext;

    public GetTags(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [FunctionName("GetTags")]
    public Task<List<Tag>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "tags")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return _queryContext.Tags
            .OrderBy(t => t.Id)
            .Select(t => new Tag
                {
                    Id = t.Id,
                    Name = t.Name,
                    Description = t.Description,
                    FilterListIds = t.FilterListTags
                        .OrderBy(flt => flt.FilterListId)
                        .Select(flt => flt.FilterListId)
                }
            ).ToListAsync(cancellationToken);
    }
}