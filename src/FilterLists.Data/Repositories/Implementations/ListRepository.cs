using System.Collections.Generic;
using System.Linq;
using FilterLists.Data.Contexts;
using FilterLists.Data.Models.Contracts;
using FilterLists.Data.Repositories.Contracts;

namespace FilterLists.Data.Repositories.Implementations
{
    public class ListRepository : IListRepository
    {
        private readonly IFilterListsDbContext _filterListsDbContext;

        public ListRepository(FilterListsDbContext filterListsDbContext)
        {
            _filterListsDbContext = filterListsDbContext;
        }

        public IEnumerable<IList> GetAll()
        {
            return _filterListsDbContext.List.AsEnumerable();
        }

        public IList GetByName(string listName)
        {
            return _filterListsDbContext.List.First(x => x.Name == listName);
        }
    }
}