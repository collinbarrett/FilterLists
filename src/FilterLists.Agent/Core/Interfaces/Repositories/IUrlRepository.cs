using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Features.Urls.Models.ValidationResults;

namespace FilterLists.Agent.Core.Interfaces.Repositories
{
    public interface IUrlRepository
    {
        Task<IEnumerable<Uri>> GetAllAsync<TModel>(CancellationToken cancellationToken);

        Task<UrlValidationResult> ValidateAsync(Uri u, CancellationToken cancellationToken);
    }
}