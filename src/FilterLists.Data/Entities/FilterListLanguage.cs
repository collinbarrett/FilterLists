namespace FilterLists.Data.Entities
{
    public class FilterListLanguage : BaseEntity
    {
        public int FilterListId { get; set; }
        public FilterList FilterList { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}