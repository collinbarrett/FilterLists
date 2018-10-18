namespace FilterLists.Data.Entities.Junctions
{
    public class FilterListLanguage : BaseJunctionEntity
    {
        public int FilterListId { get; set; }
        public FilterList FilterList { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}