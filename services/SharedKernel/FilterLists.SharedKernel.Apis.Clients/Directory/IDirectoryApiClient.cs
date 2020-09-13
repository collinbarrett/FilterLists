using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.SharedKernel.Apis.Contracts.Directory;

namespace FilterLists.SharedKernel.Apis.Clients.Directory
{
    public interface IDirectoryApiClient
    {
        Task<IEnumerable<ListVm>> GetListsAsync(CancellationToken cancellationToken = default);
        Task<ListDetailsVm> GetListDetailsAsync(int id, CancellationToken cancellationToken = default);
    }
}
