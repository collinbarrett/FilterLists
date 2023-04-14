using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Api;

internal static class ODataExtensions
{
    internal const string OrderByParamKey = "$orderby";

    internal const string OrderByParamDescription =
        "https://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part1-protocol.html#_Toc31358952";

    internal const string SkipParamKey = "$skip";

    internal const string SkipParamDescription =
        "https://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part1-protocol.html#sec_SystemQueryOptionskip";

    internal const string TopParamKey = "$top";

    internal const string TopParamDescription =
        "https://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part1-protocol.html#sec_SystemQueryOptiontop";

    internal const string CountParamKey = "$count";

    internal const string CountParamDescription =
        "https://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part1-protocol.html#sec_SystemQueryOptioncount";

    internal static IQueryable<T> ApplyODataOrderBy<T>(
        this IOrderedQueryable<T> source,
        IQueryCollection queryCollection)
    {
        var orderBy = queryCollection[OrderByParamKey].FirstOrDefault();
        return string.IsNullOrWhiteSpace(orderBy) ? source : source.OrderBy(orderBy);
    }

    internal static IQueryable<T> ApplyODataSkip<T>(
        this IQueryable<T> source,
        IQueryCollection queryCollection)
    {
        if (int.TryParse(queryCollection[SkipParamKey], out var skip))
            source = source.Skip(skip);
        return source;
    }

    internal static IQueryable<T> ApplyODataTop<T>(
        this IQueryable<T> source,
        IQueryCollection queryCollection)
    {
        if (int.TryParse(queryCollection[TopParamKey], out var top))
            source = source.Take(top);
        return source;
    }

    internal static async ValueTask<OData<List<TViewModel>>> ApplyODataCount<TEntity, TViewModel>(
        this OData<List<TViewModel>> response,
        IQueryCollection queryCollection,
        IQueryable<TEntity> source,
        CancellationToken cancellationToken)
    {
        var applyCount = queryCollection[CountParamKey].Any(c => c != "false");
        if (applyCount) response.Count = await source.CountAsync(cancellationToken);
        return response;
    }
}