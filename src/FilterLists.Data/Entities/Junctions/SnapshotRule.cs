namespace FilterLists.Data.Entities.Junctions
{
    public class SnapshotRule : BaseJunctionEntity
    {
        public int SnapshotId { get; set; }
        public Snapshot Snapshot { get; set; }
        public int RuleId { get; set; }
        public Rule Rule { get; set; }
    }
}