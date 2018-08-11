using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Services.FilterList.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.FilterList
{
    [UsedImplicitly]
    public class FilterListService : Service
    {
        public FilterListService(FilterListsDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<ListSummaryDto>> GetAllSummariesAsync() =>
            await DbContext.FilterLists.ProjectTo<ListSummaryDto>(Mapper.ConfigurationProvider).ToListAsync();

        public async Task<ListDetailsDto> GetDetailsAsync(uint id) =>
            await DbContext.FilterLists.ProjectTo<ListDetailsDto>(Mapper.ConfigurationProvider)
                           .FirstOrDefaultAsync(x => x.Id == id)
                           .FilterParentListFromMaintainerAdditionalLists();
    }
}