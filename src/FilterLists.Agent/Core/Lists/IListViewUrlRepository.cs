using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Agent.Core.Lists
{
    public interface IListViewUrlRepository
    {
        Task<IEnumerable<ListViewUrl>> GetAllAsync(CancellationToken cancellationToken);
    }
}