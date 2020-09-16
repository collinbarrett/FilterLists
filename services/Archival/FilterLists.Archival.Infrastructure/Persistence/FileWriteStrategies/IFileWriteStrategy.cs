using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Archival.Infrastructure.Persistence.FileWriteStrategies
{
    internal interface IFileWriteStrategy
    {
        Task WriteAsync(IFileToArchive file, CancellationToken cancellationToken = default);
    }
}
