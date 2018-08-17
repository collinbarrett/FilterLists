using System;

namespace FilterLists.Data.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public uint Id { get; set; }
        public DateTime? CreatedDateUtc { get; set; }
        public DateTime? ModifiedDateUtc { get; set; }
    }
}