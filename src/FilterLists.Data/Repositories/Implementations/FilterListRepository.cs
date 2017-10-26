using System.Collections.Generic;
using System.Linq;
using FilterLists.Data.Contexts;
using FilterLists.Data.Models.Contracts;
using FilterLists.Data.Repositories.Contracts;

namespace FilterLists.Data.Repositories.Implementations
{
    public class FilterListRepository : IFilterListRepository
    {
        private readonly IFilterListsDbContext filterListsDbContext;

        public FilterListRepository(FilterListsDbContext filterListsDbContext)
        {
            this.filterListsDbContext = filterListsDbContext;
        }

        public IEnumerable<IFilterList> GetAll()
        {
            return filterListsDbContext.FilterLists.AsEnumerable();
        }

        public IFilterList GetByName(string filterListName)
        {
            return filterListsDbContext.FilterLists.First(x => x.Name == filterListName);
        }
    }
}