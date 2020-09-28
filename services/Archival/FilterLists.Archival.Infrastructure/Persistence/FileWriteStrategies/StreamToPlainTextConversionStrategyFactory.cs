using FilterLists.Archival.Domain.Lists;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    internal static class StreamToPlainTextConversionStrategyFactory
    {
        public static TStrategy? GetStrategy<TStrategy>(this ListArchiveSegment segment)
            where TStrategy : class, IStreamToPlainTextConversionStrategy
        {
            // TODO: implement non-plain text strategies
            return segment.Extension.IsPlainText
                ? new PlainText() as TStrategy
                : default;
        }
    }
}
