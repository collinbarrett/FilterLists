using System;

namespace FilterLists.Data.Entities.Junctions
{
    public abstract class BaseJunctionEntity : IBaseEntity
    {
        public DateTime? CreatedDateUtc { get; set; }
    }
}