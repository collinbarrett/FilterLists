using FilterLists.Api.Persistence;
using FilterLists.Api.Persistence.Entities;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Api.Api.Types;

[ObjectType]
// ReSharper disable once ClassNeverInstantiated.Global
public class SyntaxType : ObjectType<Syntax>
{
    protected override void Configure(IObjectTypeDescriptor<Syntax> descriptor)
    {
        descriptor
            .ImplementsNode()
            .IdField(f => f.Id)
            .ResolveNode(async (context, id) =>
                await context.Service<FilterListsDbContext>().Syntaxes.FirstOrDefaultAsync(s => s.Id == id)
            );
    }
}