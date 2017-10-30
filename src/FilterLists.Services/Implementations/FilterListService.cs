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
        private readonly IMapper mapper;

        public FilterListService(IFilterListRepository filterListRepository, IMapper mapper)
        {
            this.filterListRepository = filterListRepository;
            this.mapper = mapper;
        }

        public IEnumerable<FilterListSummaryDto> GetAllSummaries()
        {
            return mapper.Map<IEnumerable<FilterListSummaryDto>>(filterListRepository.GetAll());
        }
    }
}