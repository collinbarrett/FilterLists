using System;
using System.Collections.Generic;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    internal static class StreamToPlainTextConversionStrategyFactory
    {
        private static readonly IDictionary<string, Func<IStreamToPlainTextConversionStrategy>> Strategies =
            new Dictionary<string, Func<IStreamToPlainTextConversionStrategy>>
            {
                {string.Empty, () => new PlainText()},
                {".txt", () => new PlainText()}
            };

        public static TStrategy? GetStrategy<TStrategy>(this IFileSegment segment)
            where TStrategy : class, IStreamToPlainTextConversionStrategy
        {
            return Strategies.TryGetValue(segment.SourceExtension, out var strategy)
                ? (TStrategy?)strategy()
                : default;
        }
    }
}
