using System.Linq;

namespace FilterLists.Api.GetTags;

internal static class TagQueryProjection
{
    internal static IQueryable<Tag> ProjectToTags(this IQueryable<Infrastructure.Entities.Tag> tags)
    {
        return tags.Select(t => new Tag
        {
            Id = t.Id,
            Name = t.Name,
            Description = t.Description
        });
    }
}