using System.Linq;

namespace FilterLists.Api.GetSoftware;

internal static class SoftwareQueryProjection
{
    internal static IQueryable<Software> ProjectToSoftware(this IQueryable<Infrastructure.Entities.Software> software)
    {
        return software.Select(s => new Software
        {
            Id = s.Id,
            Name = s.Name,
            Description = s.Description,
            HomeUrl = s.HomeUrl,
            DownloadUrl = s.DownloadUrl,
            SupportsAbpUrlScheme = s.SupportsAbpUrlScheme
        });
    }
}