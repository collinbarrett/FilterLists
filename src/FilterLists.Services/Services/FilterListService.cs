using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<FilterListSummaryDto>> GetAllSummaries()
        {
            return await Task.FromResult(
                mapper.Map<IEnumerable<FilterListSummaryDto>>(filterListsDbContext.FilterLists));
        }
    }
}