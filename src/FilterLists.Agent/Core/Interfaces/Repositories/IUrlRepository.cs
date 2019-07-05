using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FilterLists.Agent.Core.Interfaces.Repositories
{
    public interface IUrlRepository
    {
        Task<IEnumerable<Uri>> GetAllAsync<TModel>();
    }
}