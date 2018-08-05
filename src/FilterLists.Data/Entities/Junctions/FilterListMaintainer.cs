namespace FilterLists.Data.Entities.Junctions
{
    public class FilterListMaintainer : BaseJunctionEntity
    {
        public uint FilterListId { get; set; }
        public FilterList FilterList { get; set; }
        public uint MaintainerId { get; set; }
        public Maintainer Maintainer { get; set; }
    }
}