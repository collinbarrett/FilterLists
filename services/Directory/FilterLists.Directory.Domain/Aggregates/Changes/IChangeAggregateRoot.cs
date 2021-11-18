namespace FilterLists.Directory.Domain.Aggregates.Changes;

public interface IChange<TAggregate> where TAggregate : AggregateRoot
{
    TAggregate? Current { get; }
    TAggregate? Before { get; }
    TAggregate? After { get; }
}
