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

namespace FilterLists.Api.GetTags;

internal class GetTags
{
    private readonly IQueryContext _queryContext;

    public GetTags(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [OpenApiOperation(tags: "Tags")]
    [OpenApiParameter(ODataExtensions.OrderByParamKey, Type = typeof(string), In = ParameterLocation.Query,
        Description = ODataExtensions.OrderByParamDescription)]
    [OpenApiParameter(ODataExtensions.SkipParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.SkipParamDescription)]
    [OpenApiParameter(ODataExtensions.TopParamKey, Type = typeof(int), In = ParameterLocation.Query,
        Description = ODataExtensions.TopParamDescription)]
    [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(List<Tag>))]
    [FunctionName("GetTags")]
    public Task<List<Tag>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "tags")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return _queryContext.Tags
            .Select(t => new Tag
            {
                Id = t.Id,
                Name = t.Name,
                Description = t.Description,
                FilterListIds = t.FilterListTags
                    .OrderBy(flt => flt.FilterListId)
                    .Select(flt => flt.FilterListId)
            }).OrderBy(t => t.Id)
            .ApplyODataOrderBy(req.Query)
            .ApplyODataSkip(req.Query)
            .ApplyODataTop(req.Query)
            .ToListAsync(cancellationToken);
    }
}