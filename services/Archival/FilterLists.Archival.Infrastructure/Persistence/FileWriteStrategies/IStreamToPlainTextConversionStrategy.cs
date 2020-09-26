using System.IO;
using System.Threading;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    internal interface IStreamToPlainTextConversionStrategy
    {
        Stream Convert(IFileSegment fileSegment, CancellationToken cancellationToken);
    }
}
