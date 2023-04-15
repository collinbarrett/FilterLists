using System.Linq;

namespace FilterLists.Api.GetLicenses;

internal static class LicenseQueryProjection
{
    internal static IQueryable<License> ProjectToLicenses(this IQueryable<Infrastructure.Entities.License> licenses)
    {
        return licenses.Select(l => new License
        {
            Id = l.Id,
            Name = l.Name,
            Url = l.Url,
            PermitsModification = l.PermitsModification,
            PermitsDistribution = l.PermitsDistribution,
            PermitsCommercialUse = l.PermitsCommercialUse
        });
    }
}