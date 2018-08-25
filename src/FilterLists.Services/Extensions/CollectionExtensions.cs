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

        //https://stackoverflow.com/a/26360010/2343739
        public static void AddRange<T>(this ICollection<T> destination, IEnumerable<T> source)
        {
            if (destination is List<T> list)
                list.AddRange(source);
            else
                foreach (var item in source)
                    destination.Add(item);
        }
    }
}