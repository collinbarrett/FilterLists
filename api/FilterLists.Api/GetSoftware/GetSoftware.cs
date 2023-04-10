using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Api.GetSoftware;

internal class GetSoftware
{
    private readonly IQueryContext _queryContext;

    public GetSoftware(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [FunctionName("GetSoftware")]
    public Task<List<Software>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "software")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return _queryContext.Software
            .OrderBy(s => s.Id)
            .Select(s => new Software
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    HomeUrl = s.HomeUrl,
                    DownloadUrl = s.DownloadUrl,
                    SupportsAbpUrlScheme = s.SupportsAbpUrlScheme,
                    SyntaxIds = s.SoftwareSyntaxes
                        .OrderBy(ss => ss.SyntaxId)
                        .Select(ss => ss.SyntaxId)
                }
            ).ToListAsync(cancellationToken);
    }
}