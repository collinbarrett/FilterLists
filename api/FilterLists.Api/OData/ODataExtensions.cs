using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Api.OData;

/// <summary>
///     A **partial** custom OData implementation supporting Azure Functions
///     https://github.com/Azure/Azure-Functions/issues/1044
/// </summary>
internal static class ODataExtensions
{
    internal const string CountParamKey = "$count";

    internal const string CountParamDescription =
        "https://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part1-protocol.html#sec_SystemQueryOptioncount";

    internal const string OrderByParamKey = "$orderby";

    internal const string OrderByParamDescription =
        "https://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part1-protocol.html#_Toc31358952";

    internal const string SkipParamKey = "$skip";

    internal const string SkipParamDescription =
        "https://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part1-protocol.html#sec_SystemQueryOptionskip";

    internal const string TopParamKey = "$top";

    internal const string TopParamDescription =
        "https://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part1-protocol.html#sec_SystemQueryOptiontop";

    internal static async Task<int?> ApplyODataCount<T>(
        this IQueryable<T> source,
        IQueryCollection queryCollection,
        CancellationToken cancellationToken)
    {
        var applyCount = queryCollection[CountParamKey] == "true";
        if (applyCount) return await source.CountAsync(cancellationToken);
        return null;
    }

    internal static IQueryable<T> ApplyODataOrderBy<T>(
        this IOrderedQueryable<T> source,
        IQueryCollection queryCollection)
    {
        for (var index = 0; index < queryCollection[OrderByParamKey].Count; index++)
        {
            var query = queryCollection[OrderByParamKey][index];
            if (string.IsNullOrWhiteSpace(query)) continue;
            source = index == 0 ? source.OrderBy(query) : source.ThenBy(query);
        }

        return source;
    }

    internal static IQueryable<FilterList> ApplyODataOrderBy(
        this IOrderedQueryable<FilterList> source,
        IQueryCollection queryCollection)
    {
        for (var index = 0; index < queryCollection[OrderByParamKey].Count; index++)
        {
            var query = queryCollection[OrderByParamKey][index];
            if (query.Contains("license/name"))
            {
                if (index == 0)
                    source = query.Contains("desc")
                        ? source.OrderByDescending(fl => fl.License.Name)
                        : source.OrderBy(fl => fl.License.Name);
                else if (query.Contains("desc"))
                    source = source.ThenByDescending(fl => fl.License.Name);
                else
                    source = source.ThenBy(fl => fl.License.Name);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(query)) continue;
                source = index == 0 ? source.OrderBy(query) : source.ThenBy(query);
            }
        }

        return source;
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
}