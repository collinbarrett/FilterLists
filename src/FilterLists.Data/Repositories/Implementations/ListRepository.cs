using System.Collections.Generic;
using System.Linq;
using FilterLists.Data.Contexts;
using FilterLists.Data.Models;
using FilterLists.Data.Repositories.Contracts;

namespace FilterLists.Data.Repositories.Implementations
{
    public class ListRepository : IListRepository
    {
        private readonly IFilterListsDbContext _filterListsDbContext;

        public ListRepository(IFilterListsDbContext filterListsDbContext)
        {
            _filterListsDbContext = filterListsDbContext;
        }

        public IEnumerable<List> GetAll()
        {
            return _filterListsDbContext.List.AsEnumerable();
        }
    }
}