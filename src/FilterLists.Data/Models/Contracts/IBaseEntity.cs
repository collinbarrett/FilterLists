using System;

namespace FilterLists.Data.Models.Contracts
{
    public interface IBaseEntity
    {
        long Id { get; set; }
        DateTime AddedDateUtc { get; set; }
        DateTime? ModifiedDateUtc { get; set; }
    }
}