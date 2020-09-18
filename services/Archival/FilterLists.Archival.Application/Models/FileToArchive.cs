using System.Collections.Generic;
using System.IO;
using FilterLists.Archival.Infrastructure.Persistence;

namespace FilterLists.Archival.Application.Models
{
    internal class FileToArchive : IFileToArchive
    {
        public FileToArchive(IAsyncEnumerable<IFileToArchiveSegment> segments, FileInfo target)
        {
            Segments = segments;
            Target = target;
        }

        public IAsyncEnumerable<IFileToArchiveSegment> Segments { get; }
        public FileInfo Target { get; }
    }

    internal class FileToArchiveSegment : IFileToArchiveSegment
    {
        public FileToArchiveSegment(string sourceExtension, Stream contents)
        {
            SourceExtension = sourceExtension;
            Contents = contents;
        }

        public string SourceExtension { get; }
        public Stream Contents { get; }
    }
}
