using System.Linq;
using System.Linq.Dynamic.Core;
using Microsoft.AspNetCore.Http;

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

    internal static IQueryable<T> ApplyODataOrderBy<T>(this IOrderedQueryable<T> source,
        IQueryCollection queryCollection)
    {
        var orderBy = queryCollection[OrderByParamKey].FirstOrDefault();
        return string.IsNullOrWhiteSpace(orderBy) ? source : source.OrderBy(orderBy);
    }

    internal static IQueryable<T> ApplyODataSkip<T>(this IQueryable<T> source, IQueryCollection queryCollection)
    {
        if (int.TryParse(queryCollection[SkipParamKey], out var skip))
            source = source.Skip(skip);
        return source;
    }

    internal static IQueryable<T> ApplyODataTop<T>(this IQueryable<T> source, IQueryCollection queryCollection)
    {
        if (int.TryParse(queryCollection[TopParamKey], out var top))
            source = source.Take(top);
        return source;
    }
}