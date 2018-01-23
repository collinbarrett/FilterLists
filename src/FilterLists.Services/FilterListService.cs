using System.Collections.Generic;
using AutoMapper;
using FilterLists.Data.Repositories;
using FilterLists.Services.Models;

namespace FilterLists.Services
{
    public class FilterListService
    {
        private readonly FilterListRepository filterListRepository;
        private readonly IMapper mapper;

        public FilterListService(FilterListRepository filterListRepository, IMapper mapper)
        {
            this.filterListRepository = filterListRepository;
            this.mapper = mapper;
        }

        public IEnumerable<FilterListSummaryDto> GetAllSummaries()
        {
            return mapper.Map<IEnumerable<FilterListSummaryDto>>(filterListRepository.GetAll());
        }

        public IEnumerable<FilterListSeedDto> GetAllSeeds()
        {
            return mapper.Map<IEnumerable<FilterListSeedDto>>(filterListRepository.GetAll());
        }
    }
}