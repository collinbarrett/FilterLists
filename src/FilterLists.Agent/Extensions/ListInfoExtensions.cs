using System.Collections.Generic;
using System.Linq;
using FilterLists.Agent.Core.Entities;

namespace FilterLists.Agent.Extensions
{
    public static class ListInfoExtensions
    {
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