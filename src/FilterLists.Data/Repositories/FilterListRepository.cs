using System.Collections.Generic;
using System.Linq;
using FilterLists.Data.Entities;

namespace FilterLists.Data.Repositories
{
    public class FilterListRepository
    {
        private readonly FilterListsDbContext filterListsDbContext;

        public FilterListRepository(FilterListsDbContext filterListsDbContext)
        {
            this.filterListsDbContext = filterListsDbContext;
        }

        public IEnumerable<FilterList> GetAll()
        {
            return filterListsDbContext.FilterLists.AsEnumerable();
        }
    }
}