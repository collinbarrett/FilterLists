using System.Collections.Generic;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Language
    {
        public string Iso6391 { get; set; }
        public string Name { get; set; }
        public ICollection<FilterListLanguage> FilterListLanguages { get; set; }
    }
}