using System.Collections.Generic;

namespace FilterLists.Services.Extensions
{
    public static class CollectionExtensions
    {
        public static void AddIfNotNullOrEmpty(this ICollection<string> set, string item)
        {
            if (!string.IsNullOrEmpty(item))
                set.Add(item);
        }
    }
}