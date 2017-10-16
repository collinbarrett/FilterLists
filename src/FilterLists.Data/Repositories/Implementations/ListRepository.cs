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

        public ListRepository(FilterListsDbContext filterListsDbContext)
        {
            _filterListsDbContext = filterListsDbContext;
        }

        public IEnumerable<List> GetAll()
        {
            return _filterListsDbContext.List.AsEnumerable();
        }

        public List GetByName(string listName)
        {
            return _filterListsDbContext.List.First(x => x.Name == listName);
        }

        public void Create(List list)
        {
            _filterListsDbContext.List.Add(list);
        }

        public void DeleteAll()
        {
            _filterListsDbContext.List.RemoveRange(_filterListsDbContext.List);
        }

        public bool Any()
        {
            return _filterListsDbContext.List.Any();
        }
    }
}