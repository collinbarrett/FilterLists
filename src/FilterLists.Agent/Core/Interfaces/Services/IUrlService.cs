using System;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Features.Urls.Models.ValidationResults;

namespace FilterLists.Agent.Core.Interfaces.Services
{
    public interface IUrlService
    {
        Task<UrlValidationResult> ValidateAsync(Uri u, CancellationToken cancellationToken);
    }
}