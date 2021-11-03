namespace FilterLists.Directory.Domain.Aggregates.Licenses;

public interface ILicenseRepository
{
    ValueTask<License?> GetByIdAsync(int id, CancellationToken cancellationToken);
}
