using System.IO;
using System.Threading;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    internal interface IFileStreamConversionStrategy
    {
        Stream Convert(IFileToArchiveSegment segment, CancellationToken cancellationToken);
    }
}
