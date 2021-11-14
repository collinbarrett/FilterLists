namespace FilterLists.Directory.Domain.Aggregates.Changes;

public interface IChangeAggregate<TAggregate> where TAggregate : IAggregate
{
    TAggregate? Current { get; init; }
    TAggregate? Before { get; init; }
    TAggregate? After { get; init; }
}
