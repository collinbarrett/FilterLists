using FilterLists.Archival.Domain.SeedWork;

namespace FilterLists.Archival.Domain.ListArchives
{
    public interface IListArchiveRepository : IUnitOfWork
    {
        Task AddAsync(ListArchive listArchive, CancellationToken cancellationToken);
    }
}
