using System.Collections.Generic;
using System.IO;
using FilterLists.Archival.Infrastructure.Persistence;

namespace FilterLists.Archival.Application.Models
{
    internal class File : IFile
    {
        public File(IAsyncEnumerable<IFileSegment> segments, string targetFileName)
        {
            Segments = segments;
            TargetFileName = targetFileName;
        }

        public IAsyncEnumerable<IFileSegment> Segments { get; }
        public string TargetFileName { get; }
    }

    internal class FileSegment : IFileSegment
    {
        public FileSegment(string sourceExtension, Stream contents)
        {
            SourceExtension = sourceExtension;
            Contents = contents;
        }

        public string SourceExtension { get; }
        public Stream Contents { get; }
    }
}
