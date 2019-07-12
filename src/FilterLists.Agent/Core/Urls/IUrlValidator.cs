using System;
using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Agent.Core.Urls
{
    public interface IUrlValidator
    {
        Task<UrlValidationResult> ValidateAsync(Uri u, CancellationToken cancellationToken);
    }
}