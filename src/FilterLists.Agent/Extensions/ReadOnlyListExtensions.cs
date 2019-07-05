using System.Collections.Generic;

namespace FilterLists.Agent.Extensions
{
    public static class ReadOnlyListExtensions
    {
        public static T FirstOrDefault<T>(this IReadOnlyList<T> list)
        {
            return list.Count == 0 ? default! : list[0];
        }
    }
}