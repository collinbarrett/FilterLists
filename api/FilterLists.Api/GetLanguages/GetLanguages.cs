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

namespace FilterLists.Api.GetLanguages;

internal class GetLanguages
{
    private readonly IQueryContext _queryContext;

    public GetLanguages(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [OpenApiOperation(tags: "Languages")]
    [OpenApiParameter(ODataExtensions.OrderByParamKey, Type = typeof(string), In = ParameterLocation.Query,
        Description = ODataExtensions.OrderByParamDescription)]
    [OpenApiParameter(ODataExtensions.SkipParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.SkipParamDescription)]
    [OpenApiParameter(ODataExtensions.TopParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.TopParamDescription)]
    [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(List<Language>))]
    [FunctionName("GetLanguages")]
    public Task<List<Language>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "languages")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return _queryContext.Languages
            .Select(l => new Language
            {
                Id = l.Id,
                Iso6391 = l.Iso6391,
                Name = l.Name,
                FilterListIds = l.FilterListLanguages
                    .OrderBy(fll => fll.FilterListId)
                    .Select(fll => fll.FilterListId)
            }).OrderBy(l => l.Id)
            .ApplyODataOrderBy(req.Query)
            .ApplyODataSkip(req.Query)
            .ApplyODataTop(req.Query)
            .ToListAsync(cancellationToken);
    }
}