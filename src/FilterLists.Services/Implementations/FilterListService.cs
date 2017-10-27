using System.Collections.Generic;
using FilterLists.Data.Entities;
using FilterLists.Data.Repositories.Contracts;
using FilterLists.Services.Contracts;

namespace FilterLists.Services.Implementations
{
    public class FilterListService : IFilterListService
    {
        private readonly IFilterListRepository filterListRepository;

        public FilterListService(IFilterListRepository filterListRepository)
        {
            this.filterListRepository = filterListRepository;
        }

        public IEnumerable<FilterList> GetAll()
        {
            return filterListRepository.GetAll();
        }
    }
}