namespace FilterLists.Data.Entities.Junctions
{
    public class Dependent : BaseJunctionEntity
    {
        public uint DependentFilterListId { get; set; }
        public FilterList DependentFilterList { get; set; }
        public uint DependencyFilterListId { get; set; }
        public FilterList DependencyFilterList { get; set; }
    }
}