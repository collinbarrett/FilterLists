using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Entities;

namespace FilterLists.Agent.Core.Interfaces
{
    public interface IUrlsRepository
    {
        Task<IEnumerable<Uri>> GetAllAsync<TEntityUrls>() where TEntityUrls : IEntityUrls, new();
    }
}