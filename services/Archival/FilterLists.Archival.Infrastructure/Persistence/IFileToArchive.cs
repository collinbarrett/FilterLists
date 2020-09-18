using System.Collections.Generic;
using System.IO;

namespace FilterLists.Archival.Infrastructure.Persistence
{
    public interface IFileToArchive
    {
        // for now, assume all source segments have same extension
        string SourceExtension { get; }
        IEnumerable<Stream> Contents { get; }
        FileInfo Target { get; }
    }
}
