using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models
{
    [UsedImplicitly]
    public class LanguageSeedDto
    {
        public int Id { get; set; }
        public string Iso6391 { get; set; }
        public string Iso6392 { get; set; }
        public string Iso6392B { get; set; }
        public string Iso6392T { get; set; }
        public string Iso6393 { get; set; }
        public string LocalName { get; set; }
        public string Name { get; set; }
    }
}