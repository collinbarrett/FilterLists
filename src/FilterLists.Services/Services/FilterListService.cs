using System.Collections.Generic;
using AutoMapper;
using FilterLists.Data;
using FilterLists.Services.Models;

namespace FilterLists.Services.Services
{
    public class FilterListService
    {
        private readonly FilterListsDbContext filterListsDbContext;
        private readonly IMapper mapper;

        public FilterListService(FilterListsDbContext filterListsDbContext, IMapper mapper)
        {
            this.filterListsDbContext = filterListsDbContext;
            this.mapper = mapper;
        }

        public IEnumerable<FilterListSummaryDto> GetAllSummaries()
        {
            return mapper.Map<IEnumerable<FilterListSummaryDto>>(filterListsDbContext.FilterLists);
        }
    }
}