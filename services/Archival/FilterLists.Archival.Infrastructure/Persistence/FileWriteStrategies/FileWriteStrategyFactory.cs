using System;
using System.Linq;
using System.Reflection;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    internal static class FileWriteStrategyFactory
    {
        public static TFileWriteStrategy? GetStrategy<TFileWriteStrategy>(this IFileToArchive file)
            where TFileWriteStrategy : class, IFileWriteStrategy
        {
            var strategyType = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t =>
                    typeof(TFileWriteStrategy).IsAssignableFrom(t) &&
                    string.Equals(t.Name, file.SourceExtension.TrimStart('.'), StringComparison.OrdinalIgnoreCase));
            return strategyType is default(Type)
                ? default
                : (TFileWriteStrategy)Activator.CreateInstance(strategyType);
        }
    }
}
