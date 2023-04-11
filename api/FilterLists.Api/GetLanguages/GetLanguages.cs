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

namespace FilterLists.Api.GetLanguages;

internal class GetLanguages
{
    private readonly IQueryContext _queryContext;

    public GetLanguages(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [OpenApiOperation]
    [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(List<Language>))]
    [FunctionName("GetLanguages")]
    public Task<List<Language>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "languages")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return _queryContext.Languages
            .OrderBy(l => l.Id)
            .Select(l => new Language
                {
                    Id = l.Id,
                    Iso6391 = l.Iso6391,
                    Name = l.Name,
                    FilterListIds = l.FilterListLanguages
                        .OrderBy(fll => fll.FilterListId)
                        .Select(fll => fll.FilterListId)
                }
            ).ToListAsync(cancellationToken);
    }
}