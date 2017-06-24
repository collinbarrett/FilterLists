using System;
using System.Collections.Generic;
using System.Linq;
using FilterLists.Data.Contexts;
using FilterLists.Data.Models;
using FilterLists.Data.Repositories.Contracts;
using JetBrains.Annotations;

namespace FilterLists.Data.Repositories.Implementations
{
    [UsedImplicitly]
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

        public IEnumerable<List> UpdateAll()
        {
            throw new NotImplementedException();
        }
    }
}