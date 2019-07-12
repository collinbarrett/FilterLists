using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Agent.Core.Urls
{
    public interface IUrlRepository
    {
        Task<IEnumerable<Uri>> GetAllAsync<TModel>(CancellationToken cancellationToken);
    }
}