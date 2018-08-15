using System.Collections.Generic;

namespace FilterLists.Services.Extensions
{
    public static class EnumerableExtensions
    {
        public static void AddRange<T>(this ICollection<T> destination, IEnumerable<T> source)
        {
            foreach (var item in source)
                destination.Add(item);
        }

        public static IEnumerable<IEnumerable<T>> GetBatches<T>(this IEnumerable<T> source, int batchSize)
        {
            var batches = new List<T>(batchSize);
            foreach (var item in source)
            {
                batches.Add(item);
                if (batches.Count != batchSize)
                    continue;
                yield return batches.AsReadOnly();
                batches = new List<T>(batchSize);
            }

            if (batches.Count > 0)
                yield return batches.AsReadOnly();
        }
    }
}