using System.Collections.Generic;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Entities;

namespace FilterLists.Agent.Core.Interfaces.Repositories
{
    public interface IListInfoRepository
    {
        Task<IEnumerable<ListInfo>> GetAllAsync();
    }
}