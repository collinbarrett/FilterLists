using System;
using System.Linq;
using System.Reflection;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    internal static class StreamToTxtConversionStrategyFactory
    {
        public static TStreamToTxtConversionStrategy? GetStrategy<TStreamToTxtConversionStrategy>(
            this IFileSegment segment) where TStreamToTxtConversionStrategy : class, IStreamToTxtConversionStrategy
        {
            var strategyType = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t =>
                    typeof(TStreamToTxtConversionStrategy).IsAssignableFrom(t) &&
                    string.Equals(t.Name, segment.SourceExtension.TrimStart('.'), StringComparison.OrdinalIgnoreCase));
            return strategyType is default(Type)
                ? default
                : (TStreamToTxtConversionStrategy)Activator.CreateInstance(strategyType);
        }
    }
}
