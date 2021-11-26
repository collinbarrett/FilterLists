namespace FilterLists.SharedKernel.Domain.SeedWork;

/// <summary>
/// https://github.com/vkhorikov/CSharpFunctionalExtensions/blob/master/CSharpFunctionalExtensions/ValueObject/ValueObject.cs
/// </summary>
[Serializable]
public abstract class ValueObject : IComparable, IComparable<ValueObject>
{
    private int? _cachedHashCode;

    protected abstract IEnumerable<object?> GetEqualityComponents();

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        if (GetUnproxiedType(this) != GetUnproxiedType(obj))
            return false;

        var valueObject = (ValueObject)obj;

        return GetEqualityComponents().SequenceEqual(valueObject.GetEqualityComponents());
    }

    public override int GetHashCode()
    {
        _cachedHashCode ??= GetEqualityComponents()
            .Aggregate(
                1,
                (current, obj) =>
                {
                    unchecked
                    {
                        return current * 23 + (obj?.GetHashCode() ?? 0);
                    }
                });

        return _cachedHashCode.Value;
    }

    public virtual int CompareTo(object? obj)
    {
        var thisType = GetUnproxiedType(this);
        var otherType = GetUnproxiedType(obj);

        if (thisType != otherType)
            return string.CompareOrdinal(thisType?.ToString(), otherType?.ToString());

        var other = (ValueObject?)obj;

        var components = GetEqualityComponents().ToArray();
        var otherComponents = other?.GetEqualityComponents().ToArray() ?? Array.Empty<object?>();

        return components.Select((t, i) => CompareComponents(t, otherComponents[i]))
            .FirstOrDefault(comparison => comparison != 0);
    }

    private static int CompareComponents(object? object1, object? object2)
    {
        if (object1 is null && object2 is null)
            return 0;

        if (object1 is null)
            return -1;

        if (object2 is null)
            return 1;

        if (object1 is IComparable comparable1 && object2 is IComparable comparable2)
            return comparable1.CompareTo(comparable2);

        return object1.Equals(object2) ? 0 : -1;
    }

    public virtual int CompareTo(ValueObject? other)
    {
        return CompareTo(other as object);
    }

    public static bool operator ==(ValueObject? a, ValueObject? b)
    {
        if (a is null && b is null)
            return true;

        if (a is null || b is null)
            return false;

        return a.Equals(b);
    }

    public static bool operator !=(ValueObject? a, ValueObject? b)
    {
        return !(a == b);
    }

    internal static Type? GetUnproxiedType(object? obj)
    {
        const string EFCoreProxyPrefix = "Castle.Proxies.";
        const string NHibernateProxyPostfix = "Proxy";

        var type = obj?.GetType();
        string? typeString = type?.ToString();

        if (typeString is not null && (typeString.Contains(EFCoreProxyPrefix) || typeString.EndsWith(NHibernateProxyPostfix)))
            return type?.BaseType;

        return type;
    }
}
