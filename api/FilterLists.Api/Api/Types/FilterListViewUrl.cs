using FilterLists.Api.Persistence.Entities;
using HotChocolate.Types;

namespace FilterLists.Api.Api.Types;

[ObjectType]
public class FilterListViewUrlType : ObjectType<FilterListViewUrl>
{
    protected override void Configure(IObjectTypeDescriptor<FilterListViewUrl> descriptor)
    {
        descriptor.Field(u => u.Id).ID(nameof(FilterListViewUrl));
        descriptor.Field(u => u.FilterListId).ID(nameof(FilterList));
    }
}