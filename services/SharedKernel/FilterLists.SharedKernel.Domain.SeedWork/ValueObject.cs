namespace FilterLists.SharedKernel.Domain.SeedWork;

// TODO: implement value equality (e.g., https://enterprisecraftsmanship.com/posts/value-object-better-implementation/)
public abstract class ValueObject
{
    protected abstract IEnumerable<object?> GetEqualityComponents();
}
