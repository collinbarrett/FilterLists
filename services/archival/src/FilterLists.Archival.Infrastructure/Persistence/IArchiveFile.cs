using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Archival.Infrastructure.Persistence
{
    public interface IArchiveFile
    {
        Task ArchiveFileAsync(Stream fileContents, string fileName, CancellationToken cancellationToken = default);
    }
}