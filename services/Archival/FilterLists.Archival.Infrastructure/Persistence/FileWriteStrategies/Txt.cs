using System;
using System.IO;
using System.Threading;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    public class Txt : IStreamToTxtConversionStrategy
    {
        public Stream Convert(IFileSegment fileSegment, CancellationToken cancellationToken)
        {
            _ = fileSegment ?? throw new ArgumentNullException(nameof(fileSegment));

            return fileSegment.Contents;
        }
    }
}
