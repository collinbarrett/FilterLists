using System.Collections.Generic;
using System.IO;

namespace FilterLists.Archival.Infrastructure.Persistence
{
    public interface IFile
    {
        IAsyncEnumerable<IFileSegment> Segments { get; }
        string TargetFileName { get; }
    }

    public interface IFileSegment
    {
        string SourceExtension { get; }
        Stream Contents { get; }
    }
}
