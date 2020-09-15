using System.IO;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.SharedKernel.SeedWork;

namespace FilterLists.Archival.Infrastructure.Persistence
{
    public interface IArchiveFiles : IUnitOfWork
    {
        Task ArchiveFileAsync(
            Stream fileContents,
            string filePath,
            CancellationToken cancellationToken = default);
    }
}
