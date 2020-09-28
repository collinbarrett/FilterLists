using System;
using System.IO;
using System.Threading;
using FilterLists.Archival.Domain.Lists;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    internal class PlainText : IStreamToPlainTextConversionStrategy
    {
        public Stream Convert(ListArchiveSegment listArchiveSegment, CancellationToken cancellationToken)
        {
            _ = listArchiveSegment ?? throw new ArgumentNullException(nameof(listArchiveSegment));

            return listArchiveSegment.Content;
        }
    }
}
