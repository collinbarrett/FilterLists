using System.Collections.Generic;
using FilterLists.Data.Models.Contracts;

namespace FilterLists.Data.Repositories.Contracts
{
    public interface ITableCsvRepository
    {
        IEnumerable<ITableCsv> GetAll();
        string GetUrlByName(string name);
    }
}