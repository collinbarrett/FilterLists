using System;

namespace FilterLists.Data.Entities.Junctions
{
    public class BaseJunctionEntity : IBaseEntity
    {
        public DateTime CreatedDateUtc { get; set; }
    }
}