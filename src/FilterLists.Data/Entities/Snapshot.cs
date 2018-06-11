using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Data.Entities
{
    public class Snapshot : BaseEntity
    {
        public uint FilterListId { get; set; }
        public FilterList FilterList { get; set; }
        public string HttpStatusCode { get; set; }
        public bool IsCompleted { get; set; }
        public ICollection<SnapshotRule> AddedSnapshotRules { get; set; }
        public ICollection<SnapshotRule> RemovedSnapshotRules { get; set; }
    }
}