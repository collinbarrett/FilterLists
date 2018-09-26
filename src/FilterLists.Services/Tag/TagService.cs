using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Services.Tag.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Tag
{
    [UsedImplicitly]
    public class TagService : Service
    {
        public TagService(FilterListsDbContext dbContext, IConfigurationProvider mapConfig)
            : base(dbContext, mapConfig)
        {
        }

        public async Task<IEnumerable<TagDto>> GetAll() =>
            await DbContext.Tags
                           .OrderBy(s => s.Name)
                           .ProjectTo<TagDto>(MapConfig)
                           .ToListAsync();

        public async Task<TagDto> GetById(int id) =>
            await DbContext.Tags
                           .ProjectTo<TagDto>(MapConfig)
                           .FirstOrDefaultAsync(t => t.Id == id);
    }
}