using System.Linq;

namespace FilterLists.Api.GetMaintainers;

internal static class MaintainerQueryProjection
{
    internal static IQueryable<Maintainer> ProjectToMaintainers(
        this IQueryable<Infrastructure.Entities.Maintainer> maintainers)
    {
        return maintainers.Select(m => new Maintainer
        {
            Id = m.Id,
            Name = m.Name,
            Url = m.Url,
            EmailAddress = m.EmailAddress,
            TwitterHandle = m.TwitterHandle
        });
    }
}