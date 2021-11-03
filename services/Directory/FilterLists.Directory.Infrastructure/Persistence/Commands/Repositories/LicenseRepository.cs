using FilterLists.Directory.Domain.Aggregates.Licenses;
using FilterLists.Directory.Infrastructure.Persistence.Commands.Context;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.Repositories;

internal class LicenseRepository : ILicenseRepository
{
    private readonly ICommandContext _context;

    public LicenseRepository(ICommandContext context)
    {
        _context = context;
    }

    public ValueTask<License?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return _context.Licenses.FindAsync(new object[] { id }, cancellationToken);
    }
}
