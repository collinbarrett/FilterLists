using System.Collections.Generic;

namespace FilterLists.Services.Contracts
{
    public interface IFilterListService
    {
        IEnumerable<IFilterList> GetAll();
    }
}