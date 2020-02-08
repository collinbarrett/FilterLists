using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Services.Language.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Language
{
    [UsedImplicitly]
    public class LanguageService : Service
    {
        public LanguageService(FilterListsDbContext dbContext, IConfigurationProvider mapConfig)
            : base(dbContext, mapConfig)
        {
        }

        private IQueryable<Data.Entities.Language> TargetedLanguages =>
            DbContext.Languages.Where(l => l.FilterListLanguages.Any());

        public async Task<IEnumerable<LanguageDto>> GetAllTargetedAsync() =>
            await TargetedLanguages.ProjectTo<LanguageDto>(MapConfig)
                                   .ToListAsync();

        public async Task<LanguageDto> GetTargetedByIdAsync(int id) =>
            await TargetedLanguages.ProjectTo<LanguageDto>(MapConfig)
                                   .FirstOrDefaultAsync(l => l.Id == id);
    }
}