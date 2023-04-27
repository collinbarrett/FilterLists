using FilterLists.Api.Persistence;
using FilterLists.Api.Persistence.Entities;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Api.Api.Types;

[ObjectType]
public class MaintainerType : ObjectType<Maintainer>
{
    protected override void Configure(IObjectTypeDescriptor<Maintainer> descriptor)
    {
        descriptor
            .ImplementsNode()
            .IdField(f => f.Id)
            .ResolveNode(async (context, id) =>
                await context.Service<FilterListsDbContext>().Maintainers.FirstOrDefaultAsync(m => m.Id == id)
            );
    }
}