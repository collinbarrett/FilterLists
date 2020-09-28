using System.IO;
using System.Threading;
using FilterLists.Archival.Domain.Lists;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    internal interface IStreamToPlainTextConversionStrategy
    {
        Stream Convert(ListArchiveSegment listArchiveSegment, CancellationToken cancellationToken);
    }
}
