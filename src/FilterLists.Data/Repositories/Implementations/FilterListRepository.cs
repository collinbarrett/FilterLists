using System.Collections.Generic;
using System.Linq;
using FilterLists.Data.Entities;
using FilterLists.Data.Repositories.Contracts;

namespace FilterLists.Data.Repositories.Implementations
{
    public class FilterListRepository : IFilterListRepository
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

        public FilterList Get(int id)
        {
            return filterListsDbContext.FilterLists.Single(x => x.Id == id);
        }
    }
}