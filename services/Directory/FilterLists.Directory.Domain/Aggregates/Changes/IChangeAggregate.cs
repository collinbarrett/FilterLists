namespace FilterLists.Directory.Domain.Aggregates.Changes;

public interface IChangeAggregate<out TAggregateRecord>
{
    TAggregateRecord? Before { get; }
    TAggregateRecord? After { get; }
}
