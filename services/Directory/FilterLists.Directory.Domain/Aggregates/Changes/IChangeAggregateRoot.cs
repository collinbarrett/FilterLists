namespace FilterLists.Directory.Domain.Aggregates.Changes;

public interface IChange<TAggregate> where TAggregate : AggregateRoot
{
    TAggregate? Current { get; init; }
    TAggregate? Before { get; init; }
    TAggregate? After { get; init; }
}
