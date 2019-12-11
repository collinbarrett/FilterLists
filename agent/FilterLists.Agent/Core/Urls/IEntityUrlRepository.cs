using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Agent.Core.Urls
{
    public interface IEntityUrlRepository
    {
        Task<IEnumerable<EntityUrl>> GetAllAsync(CancellationToken cancellationToken);
    }
}