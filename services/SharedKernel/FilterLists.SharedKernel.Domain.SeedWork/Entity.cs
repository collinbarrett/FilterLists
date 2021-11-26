namespace FilterLists.SharedKernel.Domain.SeedWork;

/// <summary>
///     https://github.com/vkhorikov/CSharpFunctionalExtensions/blob/master/CSharpFunctionalExtensions/Entity/Entity.cs
/// </summary>
public abstract class Entity<TId>
{
    protected Entity() { }

    protected Entity(TId id)
    {
        Id = id;
    }

    public virtual TId Id { get; protected set; } = default!;

    public override bool Equals(object? obj)
    {
        if (obj is not Entity<TId> other)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        if (ValueObject.GetUnproxiedType(this) != ValueObject.GetUnproxiedType(other))
        {
            return false;
        }

        if (IsTransient() || other.IsTransient())
        {
            return false;
        }

        return Id is not null && Id.Equals(other.Id);
    }

    private bool IsTransient()
    {
        return Id is null || Id.Equals(default(TId));
    }

    public static bool operator ==(Entity<TId>? a, Entity<TId>? b)
    {
        if (a is null && b is null)
        {
            return true;
        }

        if (a is null || b is null)
        {
            return false;
        }

        return a.Equals(b);
    }

    public static bool operator !=(Entity<TId>? a, Entity<TId>? b)
    {
        return !(a == b);
    }

    public override int GetHashCode()
    {
        return (ValueObject.GetUnproxiedType(this)?.ToString() + Id).GetHashCode();
    }
}

public abstract class Entity : Entity<long>
{
    protected Entity() { }

    protected Entity(long id)
        : base(id) { }
}
