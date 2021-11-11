using FilterLists.Archival.Domain.ListArchives;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies;

internal interface IStreamToPlainTextConversionStrategy
{
    Stream Convert(ListArchiveSegment listArchiveSegment, CancellationToken cancellationToken);
}
