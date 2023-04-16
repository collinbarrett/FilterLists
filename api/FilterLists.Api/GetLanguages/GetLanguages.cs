using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Infrastructure.Context;
using FilterLists.Api.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace FilterLists.Api.GetLanguages;

public class GetLanguages
{
    private readonly IQueryContext _queryContext;

    public GetLanguages(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [OpenApiOperation(tags: nameof(Infrastructure.Entities.Language))]
    [OpenApiParameter(ODataExtensions.OrderByParamKey, Type = typeof(string), In = ParameterLocation.Query,
        Description = ODataExtensions.OrderByParamDescription)]
    [OpenApiParameter(ODataExtensions.SkipParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.SkipParamDescription)]
    [OpenApiParameter(ODataExtensions.TopParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.TopParamDescription)]
    [OpenApiParameter(ODataExtensions.CountParamKey, Type = typeof(bool), In = ParameterLocation.Query,
        Description = ODataExtensions.CountParamDescription)]
    [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(OData<List<Language>>))]
    [FunctionName(nameof(GetLanguages))]
    public async Task<OData<List<Language>>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "languages")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return new OData<List<Language>>
        {
            Value = await _queryContext.Languages
                .OrderBy(l => l.Id)
                .ApplyODataOrderBy(req.Query)
                .ApplyODataSkip(req.Query)
                .ApplyODataTop(req.Query)
                .ProjectToLanguages()
                .ToListAsync(cancellationToken),
            Count = await _queryContext.Languages
                .ApplyODataSkip(req.Query)
                .ApplyODataTop(req.Query)
                .ApplyODataCount(req.Query, cancellationToken)
        };
    }
}