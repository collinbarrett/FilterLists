using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Agent.Core.List
{
    public interface IListRepository
    {
        Task<Stream> GetListStreamAsync(Uri url, CancellationToken cancellationToken);
    }
}