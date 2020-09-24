using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Directory.Api.Contracts.Models;
using Refit;

namespace FilterLists.Directory.Api.Contracts
{
    public interface IDirectoryApi
    {
        [Get("/lists")]
        Task<IEnumerable<ListVm>> GetListsAsync(CancellationToken cancellationToken);

        [Get("/lists/{id}")]
        Task<ListDetailsVm> GetListDetailsAsync(int id, CancellationToken cancellationToken);
    }
}
