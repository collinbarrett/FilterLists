using System.Collections.Generic;
using System.Linq;
using FilterLists.Data.Contexts;
using FilterLists.Data.Contracts.Repositories;
using FilterLists.Models;

namespace FilterLists.Data.Repositories
{
    public class ListRepository : IListRepository
    {
        private readonly FilterListsDbContext _filterListsDbContext;

        public ListRepository(FilterListsDbContext filterListsDbContext)
        {
            _filterListsDbContext = filterListsDbContext;
        }

        public IEnumerable<List> GetAll()
        {
            return _filterListsDbContext.List.AsEnumerable();
        }
    }
}