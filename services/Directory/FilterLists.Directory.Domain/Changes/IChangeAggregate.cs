using FilterLists.SharedKernel.Domain.SeedWork;

namespace FilterLists.Directory.Domain.Changes;

public interface IChangeAggregate<out TAggregateValueObject> where TAggregateValueObject : ValueObject
{
    TAggregateValueObject? Before { get; }
    TAggregateValueObject? After { get; }
}
