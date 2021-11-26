using FilterLists.Directory.Domain.Aggregates.FilterLists;

namespace FilterLists.Directory.Domain.Aggregates.Changes;

public class FilterListChange : Change, IChangeAggregate<FilterListValueObject>
{
    protected FilterListChange() { }

    public FilterListValueObject? Before { get; private init; }
    public FilterListValueObject? After { get; private init; }

    public static FilterListChange Create(FilterList filterList, string? reason)
    {
        return new FilterListChange { After = FilterListValueObject.FromFilterList(filterList), Reason = reason };
    }

    public static FilterListChange Update(FilterList before, FilterList after, string? reason)
    {
        return new FilterListChange
        {
            Before = FilterListValueObject.FromFilterList(before),
            After = FilterListValueObject.FromFilterList(after),
            Reason = reason
        };
    }

    public static FilterListChange Delete(FilterList filterList, string? reason)
    {
        return new FilterListChange { Before = FilterListValueObject.FromFilterList(filterList), Reason = reason };
    }
}
