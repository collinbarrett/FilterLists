using System.Collections.Generic;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Entities;

namespace FilterLists.Agent.Core.Interfaces
{
    public interface IEntityUrlsRepository
    {
        Task<IEnumerable<TEntityUrls>> GetAllAsync<TEntityUrls>() where TEntityUrls : IEntityUrls, new();
    }
}