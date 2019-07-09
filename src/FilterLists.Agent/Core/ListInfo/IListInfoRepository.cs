using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Agent.Core.ListInfo
{
    public interface IListInfoRepository
    {
        Task<IEnumerable<ListInfo>> GetAllAsync(CancellationToken cancellationToken);
    }
}