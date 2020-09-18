using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Archival.Infrastructure.Clients
{
    public interface IFileClient : IDisposable
    {
        Task<Stream> DownloadFileAsync(Uri url, CancellationToken cancellationToken);
    }
}
