using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Agent.Core.Lists
{
    public interface IListRepository
    {
        Task<Stream> GetAsStreamAsync(Uri url, CancellationToken cancellationToken);
    }
}