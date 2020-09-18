using System.Collections.Generic;
using System.IO;
using FilterLists.Archival.Infrastructure.Persistence;

namespace FilterLists.Archival.Application.Models
{
    internal class FileToArchive : IFileToArchive
    {
        public FileToArchive(string sourceExtension, IEnumerable<Stream> contents, FileInfo target)
        {
            SourceExtension = sourceExtension;
            Contents = contents;
            Target = target;
        }

        public string SourceExtension { get; }
        public IEnumerable<Stream> Contents { get; }
        public FileInfo Target { get; }
    }
}
