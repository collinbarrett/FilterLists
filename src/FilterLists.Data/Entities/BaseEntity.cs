using System;

namespace FilterLists.Data.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public uint Id { get; set; }
        public DateTime? CreatedDateUtc { get; set; }
        public DateTime? ModifiedDateUtc { get; set; }
    }
}