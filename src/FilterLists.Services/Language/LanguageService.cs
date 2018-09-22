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

        public async Task<IEnumerable<LanguageDto>> GetAllTargeted() =>
            await DbContext.Languages
                           .Where(l => l.FilterListLanguages.Any())
                           .OrderBy(s => s.Name)
                           .ProjectTo<LanguageDto>(MapConfig)
                           .ToListAsync();
    }
}