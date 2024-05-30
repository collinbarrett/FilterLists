namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public abstract record Entity
{
    public long Id { get; init; }
}