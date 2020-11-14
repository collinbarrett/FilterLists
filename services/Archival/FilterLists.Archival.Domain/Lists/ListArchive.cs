using System.Collections.Generic;

namespace FilterLists.Archival.Domain.Lists
{
    public class ListArchive
    {
        public ListArchive(IAsyncEnumerable<ListArchiveSegment> segments, ListFileName targetFileName)
        {
            Segments = segments;
            TargetFileName = targetFileName;
        }

        public IAsyncEnumerable<ListArchiveSegment> Segments { get; }
        public ListFileName TargetFileName { get; }
    }
}
