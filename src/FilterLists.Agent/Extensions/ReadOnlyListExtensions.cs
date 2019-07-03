using System.Collections.Generic;

namespace FilterLists.Agent.Extensions
{
    public static class ReadOnlyListExtensions
    {
        public static T FirstOrDefault<T>(this IReadOnlyList<T> list)
        {
            if (list is null || list.Count == 0)
                return default;
            return list[0];
        }
    }
}