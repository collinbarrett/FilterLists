using System.Collections.Generic;
using FilterLists.Models;

namespace FilterLists.Data.Contracts.Repositories
{
    public interface IListRepository
    {
        IEnumerable<List> GetAll();
    }
}