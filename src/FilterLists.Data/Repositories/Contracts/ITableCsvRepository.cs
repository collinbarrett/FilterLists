using System.Collections.Generic;
using FilterLists.Data.Models;

namespace FilterLists.Data.Repositories.Contracts
{
    public interface ITableCsvRepository
    {
        IEnumerable<TableCsv> GetAll();
        string GetUrlByName(string name);
    }
}