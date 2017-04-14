using System.Collections.Generic;
using FilterLists.Data.Models;

namespace FilterLists.Services.Contracts
{
    public interface IListService
    {
        IEnumerable<List> GetAll();
    }
}