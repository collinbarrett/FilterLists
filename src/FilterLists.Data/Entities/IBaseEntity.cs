using System;

namespace FilterLists.Data.Entities
{
    public interface IBaseEntity
    {
        DateTime? CreatedDateUtc { get; set; }
    }
}