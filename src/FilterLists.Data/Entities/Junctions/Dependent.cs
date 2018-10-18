namespace FilterLists.Data.Entities.Junctions
{
    public class Dependent : BaseJunctionEntity
    {
        public int DependentFilterListId { get; set; }
        public FilterList DependentFilterList { get; set; }
        public int DependencyFilterListId { get; set; }
        public FilterList DependencyFilterList { get; set; }
    }
}