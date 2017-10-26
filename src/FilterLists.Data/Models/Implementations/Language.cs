using FilterLists.Data.Models.Contracts;

namespace FilterLists.Data.Models.Implementations
{
    public class Language : BaseEntity, ILanguage
    {
        public string Iso6391 { get; set; }
        public string Iso6392 { get; set; }
        public string Iso6392B { get; set; }
        public string Iso6392T { get; set; }
        public string Iso6393 { get; set; }
        public string LocalName { get; set; }
        public string Name { get; set; }
    }
}