using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models.Junctions
{
    [UsedImplicitly]
    public class FilterListLanguageSeedDto
    {
        public int FilterListId { get; set; }
        public int LanguageId { get; set; }
    }
}