namespace FilterLists.Directory.Domain.Aggregates.Changes;

public interface IChange<out TAggregateRootCore> where TAggregateRootCore : AggregateRootCore
{
    TAggregateRootCore? Before { get; }
    TAggregateRootCore? After { get; }
}
