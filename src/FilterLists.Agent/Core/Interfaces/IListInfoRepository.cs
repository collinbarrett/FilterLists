using System.Collections.Generic;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Entities;

namespace FilterLists.Agent.Core.Interfaces
{
    public interface IListInfoRepository
    {
        Task<IEnumerable<ListInfo>> GetAll();
    }
}