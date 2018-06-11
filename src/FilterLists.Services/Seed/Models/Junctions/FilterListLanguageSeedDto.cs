using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models.Junctions
{
    [UsedImplicitly]
    public class FilterListLanguageSeedDto
    {
        public uint FilterListId { get; set; }
        public uint LanguageId { get; set; }
    }
}