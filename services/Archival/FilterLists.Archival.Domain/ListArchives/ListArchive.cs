using System.Collections.Generic;

namespace FilterLists.Archival.Domain.ListArchives
{
    public class ListArchive
    {
        public ListArchive(int id, IAsyncEnumerable<ListArchiveSegment> segments)
        {
            Id = id;
            Segments = segments;
        }

        public int Id { get; }

        public IAsyncEnumerable<ListArchiveSegment> Segments { get; }
    }
}
