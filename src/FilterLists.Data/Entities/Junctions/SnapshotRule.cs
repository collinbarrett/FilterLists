namespace FilterLists.Data.Entities.Junctions
{
    public class SnapshotRule : BaseJunctionEntity
    {
        public uint SnapshotId { get; set; }
        public Snapshot Snapshot { get; set; }
        public uint RuleId { get; set; }
        public Rule Rule { get; set; }
    }
}