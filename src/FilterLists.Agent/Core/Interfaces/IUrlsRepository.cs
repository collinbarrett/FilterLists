using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FilterLists.Agent.Core.Interfaces
{
    public interface IUrlsRepository
    {
        Task<IEnumerable<Uri>> GetAllAsync<TModel>();
    }
}