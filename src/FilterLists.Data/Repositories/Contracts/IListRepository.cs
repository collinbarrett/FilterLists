using System.Collections.Generic;
using FilterLists.Data.Models.Contracts;

namespace FilterLists.Data.Repositories.Contracts
{
    public interface IListRepository
    {
        IEnumerable<IList> GetAll();
        IList GetByName(string listName);
    }
}