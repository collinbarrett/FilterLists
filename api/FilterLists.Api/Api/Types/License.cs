using FilterLists.Api.Persistence;
using FilterLists.Api.Persistence.Entities;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Api.Api.Types;

[ObjectType]
public class LicenseType : ObjectType<License>
{
    protected override void Configure(IObjectTypeDescriptor<License> descriptor)
    {
        descriptor
            .ImplementsNode()
            .IdField(f => f.Id)
            .ResolveNode(async (context, id) =>
                await context.Service<FilterListsDbContext>().Licenses.FirstOrDefaultAsync(l => l.Id == id)
            );
    }
}