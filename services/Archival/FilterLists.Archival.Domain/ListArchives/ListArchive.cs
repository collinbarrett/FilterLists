namespace FilterLists.Archival.Domain.ListArchives;

public record ListArchive(int Id, IAsyncEnumerable<ListArchiveSegment> Segments);
