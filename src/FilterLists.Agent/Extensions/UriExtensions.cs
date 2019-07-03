using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FilterLists.Agent.Core.Entities;

namespace FilterLists.Agent.Extensions
{
    public static class UriExtensions
    {
        public static string GetExtension(this Uri uri)
        {
            return Path.GetExtension(uri.AbsolutePath);
        }

        public static bool IsValidUrl(this Uri uri)
        {
            var uriString = uri.OriginalString;
            if (!Uri.IsWellFormedUriString(uriString, UriKind.Absolute))
                return false;
            if (!Uri.TryCreate(uriString, UriKind.Absolute, out var tmp))
                return false;
            return tmp.Scheme == Uri.UriSchemeHttp || tmp.Scheme == Uri.UriSchemeHttps;
        }

        public static IEnumerable<Uri> DistributeByHost(this IEnumerable<Uri> listInfo)
        {
            var listInfoList = listInfo.ToList();
            var distributedLists = listInfoList.Where(u => u.IsValidUrl())
                .GroupBy(u => u.Host)
                .SelectMany((g, gi) => g.Select((u, i) => new {Index = i, GroupIndex = gi, ListInfo = u}))
                .OrderBy(a => a.Index)
                .ThenBy(a => a.GroupIndex)
                .Select(a => a.ListInfo);
            return listInfoList.Where(u => !u.IsValidUrl()).Concat(distributedLists);
        }

        public static IEnumerable<ListInfo> DistributeByHost(this IEnumerable<ListInfo> listInfo)
        {
            return listInfo.GroupBy(l => l.ViewUrl.Host)
                .SelectMany((g, gi) => g.Select((l, i) => new {Index = i, GroupIndex = gi, ListInfo = l}))
                .OrderBy(a => a.Index)
                .ThenBy(a => a.GroupIndex)
                .Select(a => a.ListInfo);
        }
    }
}