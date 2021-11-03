namespace FilterLists.Directory.Domain.Aggregates.Changes;

public interface IChangeRepository
{
    Task AddAsync(Change change, CancellationToken cancellationToken);
}
