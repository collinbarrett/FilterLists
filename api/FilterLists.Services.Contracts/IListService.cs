using System.Collections.Generic;
using FilterLists.Models;

namespace FilterLists.Services.Contracts
{
    public interface IListService
    {
        IEnumerable<List> GetAll();
    }
}