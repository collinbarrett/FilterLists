using System.Linq;

namespace FilterLists.Api.GetSyntaxes;

internal static class SyntaxQueryProjection
{
    internal static IQueryable<Syntax> ProjectToSyntaxes(this IQueryable<Infrastructure.Entities.Syntax> syntaxes)
    {
        return syntaxes.Select(s => new Syntax
        {
            Id = s.Id,
            Name = s.Name,
            Description = s.Description,
            Url = s.Url
        });
    }
}