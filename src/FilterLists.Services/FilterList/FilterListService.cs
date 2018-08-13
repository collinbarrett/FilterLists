using System.Collections.Generic;
using System.Linq;
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
        public FilterListService(FilterListsDbContext dbContext, IConfigurationProvider configurationProvider) :
            base(dbContext, configurationProvider)
        {
        }

        public async Task<IEnumerable<ListSummaryDto>> GetAllSummariesAsync() =>
            await DbContext.FilterLists.OrderBy(l => l.Name)
                           .ProjectTo<ListSummaryDto>(ConfigurationProvider)
                           .ToListAsync();

        public async Task<ListDetailsDto> GetDetailsAsync(uint id) =>
            await DbContext.FilterLists.ProjectTo<ListDetailsDto>(ConfigurationProvider)
                           .FirstOrDefaultAsync(x => x.Id == id)
                           .FilterParentListFromMaintainerAdditionalLists();
    }
}