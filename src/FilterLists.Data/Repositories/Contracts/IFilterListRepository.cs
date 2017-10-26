using System.Collections.Generic;
using FilterLists.Data.Models.Contracts;

namespace FilterLists.Data.Repositories.Contracts
{
    public interface IFilterListRepository
    {
        IEnumerable<IFilterList> GetAll();
        IFilterList GetByName(string filterListName);
    }
}