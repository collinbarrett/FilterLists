using System.Threading;
using System.Threading.Tasks;
using FilterLists.Archival.Domain.SeedWork;

namespace FilterLists.Archival.Domain.Lists
{
    public interface IListArchiveRepository : IUnitOfWork
    {
        Task AddAsync(ListArchive listArchive, CancellationToken cancellationToken);
    }
}
