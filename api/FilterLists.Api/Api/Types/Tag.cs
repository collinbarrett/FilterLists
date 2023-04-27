using FilterLists.Api.Persistence;
using FilterLists.Api.Persistence.Entities;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Api.Api.Types;

[ObjectType]
public class TagType : ObjectType<Tag>
{
    protected override void Configure(IObjectTypeDescriptor<Tag> descriptor)
    {
        descriptor
            .ImplementsNode()
            .IdField(f => f.Id)
            .ResolveNode(async (context, id) =>
                await context.Service<FilterListsDbContext>().Tags.FirstOrDefaultAsync(t => t.Id == id)
            );
    }
}