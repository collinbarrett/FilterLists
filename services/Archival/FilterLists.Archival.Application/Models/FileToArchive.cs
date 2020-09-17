using System.Collections.Generic;
using System.IO;
using FilterLists.Archival.Infrastructure.Persistence;

namespace FilterLists.Archival.Application.Models
{
    internal class FileToArchive : IFileToArchive
    {
        public FileToArchive(FileInfo target, IEnumerable<Stream> contents)
        {
            Target = target;
            Contents = contents;
        }

        public FileInfo Target { get; }
        public IEnumerable<Stream> Contents { get; }
    }
}
