using System.Collections.Generic;
using System.IO;

namespace FilterLists.Archival.Infrastructure.Persistence
{
    public interface IFileToArchive
    {
        IAsyncEnumerable<IFileToArchiveSegment> Segments { get; }
        FileInfo Target { get; }
    }

    public interface IFileToArchiveSegment
    {
        string SourceExtension { get; }
        Stream Contents { get; }
    }
}
