using System;

namespace FilterLists.Data.Models.Contracts
{
    public interface ITableCsv
    {
        string Name { get; set; }
        string Url { get; set; }
        long Id { get; set; }
        DateTime AddedDateUtc { get; set; }
        DateTime? ModifiedDateUtc { get; set; }
    }
}