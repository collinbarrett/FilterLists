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

        private IQueryable<Data.Entities.Tag> ImplementedTags =>
            DbContext.Tags.Where(t => t.FilterListTags.Any());

        public async Task<IEnumerable<TagDto>> GetAllImplemented() =>
            await ImplementedTags.ProjectTo<TagDto>(MapConfig)
                                 .ToListAsync();

        public async Task<TagDto> GetImplementedById(int id) =>
            await ImplementedTags.ProjectTo<TagDto>(MapConfig)
                                 .FirstOrDefaultAsync(t => t.Id == id);
    }
}