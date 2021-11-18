namespace FilterLists.Directory.Domain.Aggregates.Changes;

public interface IChange<out TAggregate> where TAggregate : AggregateRoot
{
    TAggregate? Current { get; }
    TAggregate? Before { get; }
    TAggregate? After { get; }
}
