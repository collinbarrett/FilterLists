using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Services.FilterList.Models;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.FilterList
{
    public class FilterListService : Service
    {
        public FilterListService(FilterListsDbContext dbContext, IConfigurationProvider mapConfig)
            : base(dbContext, mapConfig)
        {
        }

        public async Task<IEnumerable<FilterListDto>> GetAllAsync()
        {
            return await DbContext.FilterLists
                .Where(fl => fl.IsDeleted != true)
                .ProjectTo<FilterListDto>(MapConfig)
                .ToListAsync();
        }

        public async Task<FilterListDto> GetByIdAsync(int id)
        {
            return await DbContext.FilterLists
                .Where(fl => fl.IsDeleted != true)
                .ProjectTo<FilterListDto>(MapConfig)
                .FirstOrDefaultAsync(l => l.Id == id);
        }
    }
}