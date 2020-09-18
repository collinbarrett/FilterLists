using System;
using System.IO;
using System.Threading;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    public class Txt : IFileStreamConversionStrategy
    {
        public Stream Convert(IFileToArchiveSegment segment, CancellationToken cancellationToken)
        {
            _ = segment ?? throw new ArgumentNullException(nameof(segment));

            return segment.Contents;
        }
    }
}
