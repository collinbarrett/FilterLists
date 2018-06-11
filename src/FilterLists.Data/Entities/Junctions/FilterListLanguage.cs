namespace FilterLists.Data.Entities.Junctions
{
    public class FilterListLanguage : BaseJunction
    {
        public uint FilterListId { get; set; }
        public FilterList FilterList { get; set; }
        public uint LanguageId { get; set; }
        public Language Language { get; set; }
    }
}