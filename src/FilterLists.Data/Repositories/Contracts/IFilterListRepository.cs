using System.Collections.Generic;
using FilterLists.Data.Entities;

namespace FilterLists.Data.Repositories.Contracts
{
    public interface IFilterListRepository
    {
        IEnumerable<FilterList> GetAll();
    }
}