using System;
using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Data.Entities
{
    public class Snapshot : BaseEntity
    {
        public uint? BatchSize { get; set; }
        public uint FilterListId { get; set; }
        public FilterList FilterList { get; set; }
        public int? HttpStatusCode { get; set; }
        public bool WasSuccessful { get; set; }
        public ICollection<SnapshotRule> SnapshotRules { get; set; }
        public DateTime? WaybackTimestamp { get; set; }
    }
}