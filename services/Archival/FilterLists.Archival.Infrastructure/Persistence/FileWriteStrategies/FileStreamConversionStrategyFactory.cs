using System;
using System.Linq;
using System.Reflection;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    internal static class FileStreamConversionStrategyFactory
    {
        public static TFileStreamConversionStrategy? GetStrategy<TFileStreamConversionStrategy>(
            this IFileToArchiveSegment segment)
            where TFileStreamConversionStrategy : class, IFileStreamConversionStrategy
        {
            var strategyType = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t =>
                    typeof(TFileStreamConversionStrategy).IsAssignableFrom(t) &&
                    string.Equals(t.Name, segment.SourceExtension.TrimStart('.'), StringComparison.OrdinalIgnoreCase));
            return strategyType is default(Type)
                ? default
                : (TFileStreamConversionStrategy)Activator.CreateInstance(strategyType);
        }
    }
}
