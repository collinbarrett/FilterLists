namespace FilterLists.Data.Entities
{
    public class FilterListRule : BaseEntity
    {
        public int FilterListId { get; set; }
        public FilterList FilterList { get; set; }

        public int RuleId { get; set; }
        public Rule Rule { get; set; }
    }
}