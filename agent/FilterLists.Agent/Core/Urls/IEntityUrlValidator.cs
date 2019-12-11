using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Agent.Core.Urls
{
    public interface IEntityUrlValidator
    {
        Task<EntityUrl> ValidateAsync(EntityUrl entityUrl, CancellationToken cancellationToken);
    }
}