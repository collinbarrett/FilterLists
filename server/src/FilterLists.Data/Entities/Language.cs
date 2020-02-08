using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;
using JetBrains.Annotations;

namespace FilterLists.Data.Entities
{
    [UsedImplicitly]
    public class Language : BaseEntity
    {
        public ICollection<FilterListLanguage> FilterListLanguages { get; set; }
        public string Iso6391 { get; set; }
        public string Iso6392 { get; set; }
        public string Iso6392B { get; set; }
        public string Iso6392T { get; set; }
        public string Iso6393 { get; set; }
        public string LocalName { get; set; }
        public string Name { get; set; }
    }
}