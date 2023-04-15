using System.Linq;

namespace FilterLists.Api.GetLanguages;

internal static class LanguageQueryProjection
{
    internal static IQueryable<Language> ProjectToLanguages(this IQueryable<Infrastructure.Entities.Language> languages)
    {
        return languages.Select(l => new Language
        {
            Id = l.Id,
            Iso6391 = l.Iso6391,
            Name = l.Name
        });
    }
}