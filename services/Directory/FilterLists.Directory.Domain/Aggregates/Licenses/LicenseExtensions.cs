namespace FilterLists.Directory.Domain.Aggregates.Licenses;

public static class LicenseExtensions
{
    public static IQueryable<License> WhereIsDefaultForFilterList(this IQueryable<License> licenses)
    {
        return licenses.Where(l => l.Name == "All Rights Reserved");
    }
}
