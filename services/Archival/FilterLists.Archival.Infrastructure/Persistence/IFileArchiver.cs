using System.Threading;
using System.Threading.Tasks;
using FilterLists.SharedKernel.SeedWork;

namespace FilterLists.Archival.Infrastructure.Persistence
{
    public interface IFileArchiver : IUnitOfWork
    {
        Task ArchiveFileAsync(
            IFileToArchive file,
            CancellationToken cancellationToken);
    }
}
