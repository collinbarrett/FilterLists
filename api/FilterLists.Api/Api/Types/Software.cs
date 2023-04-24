using FilterLists.Api.Persistence;
using FilterLists.Api.Persistence.Entities;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Api.Api.Types;

[ObjectType]
// ReSharper disable once ClassNeverInstantiated.Global
public class SoftwareType : ObjectType<Software>
{
    protected override void Configure(IObjectTypeDescriptor<Software> descriptor)
    {
        descriptor
            .ImplementsNode()
            .IdField(f => f.Id)
            .ResolveNode(async (context, id) =>
                await context.Service<FilterListsDbContext>().Software.FirstOrDefaultAsync(s => s.Id == id)
            );
    }
}