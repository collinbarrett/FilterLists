using FilterLists.Directory.Domain.Aggregates.Changes;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.Repositories;

internal class ChangeRepository : IChangeRepository
{
    public Task AddAsync(Change change, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
