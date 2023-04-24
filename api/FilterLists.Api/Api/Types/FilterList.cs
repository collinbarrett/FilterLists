using FilterLists.Api.Persistence;
using FilterLists.Api.Persistence.Entities;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Api.Api.Types;

[ObjectType]
// ReSharper disable once ClassNeverInstantiated.Global
public class FilterListType : ObjectType<FilterList>
{
    protected override void Configure(IObjectTypeDescriptor<FilterList> descriptor)
    {
        descriptor
            .ImplementsNode()
            .IdField(f => f.Id)
            .ResolveNode(async (context, id) =>
                await context.Service<FilterListsDbContext>().FilterLists.FirstOrDefaultAsync(fl => fl.Id == id)
            );
    }
}