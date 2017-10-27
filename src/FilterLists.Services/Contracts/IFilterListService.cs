using System.Collections.Generic;
using FilterLists.Data.Entities;

namespace FilterLists.Services.Contracts
{
    public interface IFilterListService
    {
        IEnumerable<FilterList> GetAll();
    }
}