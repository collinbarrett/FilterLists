using System.Collections.Generic;
using System.IO;

namespace FilterLists.Archival.Infrastructure.Persistence
{
    public interface IFileToArchive
    {
        FileInfo Target { get; }
        IEnumerable<Stream> Contents { get; }
    }
}
