using System.IO;
using System.Threading;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    internal interface IStreamToTxtConversionStrategy
    {
        Stream Convert(IFileSegment fileSegment, CancellationToken cancellationToken);
    }
}
