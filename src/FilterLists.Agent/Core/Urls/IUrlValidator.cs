using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Agent.Core.Urls
{
    public interface IUrlValidator
    {
        Task<EntityUrl> ValidateAsync(EntityUrl entityUrl, CancellationToken cancellationToken);
    }
}