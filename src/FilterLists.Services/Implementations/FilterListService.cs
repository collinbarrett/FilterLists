using System.Collections.Generic;
using AutoMapper;
using FilterLists.Data.Repositories.Contracts;
using FilterLists.Services.Contracts;
using FilterLists.Services.Models;

namespace FilterLists.Services.Implementations
{
    public class FilterListService : IFilterListService
    {
        private readonly IFilterListRepository filterListRepository;

        public FilterListService(IFilterListRepository filterListRepository)
        {
            this.filterListRepository = filterListRepository;
        }

        public IEnumerable<FilterListSummaryDto> GetAllSummaries()
        {
            return Mapper.Map<IEnumerable<FilterListSummaryDto>>(filterListRepository.GetAll());
        }
    }
}