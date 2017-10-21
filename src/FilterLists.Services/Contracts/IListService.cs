using System.Collections.Generic;
using FilterLists.Data.Models.Contracts;

namespace FilterLists.Services.Contracts
{
    public interface IListService
    {
        IEnumerable<IList> GetAll();
    }
}