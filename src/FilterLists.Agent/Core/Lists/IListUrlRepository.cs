using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Agent.Core.Lists
{
    public interface IListUrlRepository
    {
        Task<IEnumerable<ListUrl>> GetAllAsync(CancellationToken cancellationToken);
    }
}