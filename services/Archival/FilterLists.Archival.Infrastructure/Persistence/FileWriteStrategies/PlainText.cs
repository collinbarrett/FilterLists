using System.IO;
using System.Threading;
using FilterLists.Archival.Domain.Lists;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    internal class PlainText : IStreamToPlainTextConversionStrategy
    {
        public Stream Convert(ListArchiveSegment listArchiveSegment, CancellationToken cancellationToken)
        {
            return listArchiveSegment.Content;
        }
    }
}
