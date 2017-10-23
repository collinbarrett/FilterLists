using System.Collections.Generic;
using System.Linq;
using FilterLists.Data.Contexts;
using FilterLists.Data.Models.Contracts;
using FilterLists.Data.Repositories.Contracts;

namespace FilterLists.Data.Repositories.Implementations
{
    public class ListRepository : IListRepository
    {
        private readonly IFilterListsDbContext filterListsDbContext;

        public ListRepository(FilterListsDbContext filterListsDbContext)
        {
            this.filterListsDbContext = filterListsDbContext;
        }

        public IEnumerable<IList> GetAll()
        {
            return filterListsDbContext.List.AsEnumerable();
        }

        public IList GetByName(string listName)
        {
            return filterListsDbContext.List.First(x => x.Name == listName);
        }
    }
}