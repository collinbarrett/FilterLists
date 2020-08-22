using System.Collections.Generic;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Language
    {
        public string Iso6391 { get; } = null!;
        public string Name { get; } = null!;
        public ICollection<FilterListLanguage> FilterListLanguages { get; } = new HashSet<FilterListLanguage>();
    }
}