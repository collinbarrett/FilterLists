using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Services.Syntax.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Syntax
{
    [UsedImplicitly]
    public class SyntaxService : Service
    {
        public SyntaxService(FilterListsDbContext dbContext, IConfigurationProvider mapConfig)
            : base(dbContext, mapConfig)
        {
        }

        public async Task<IEnumerable<SyntaxDto>> GetAll() =>
            await DbContext.Syntaxes
                           .ProjectTo<SyntaxDto>(MapConfig)
                           .ToListAsync();

        public async Task<SyntaxDto> GetById(int id) =>
            await DbContext.Syntaxes
                           .ProjectTo<SyntaxDto>(MapConfig)
                           .FirstOrDefaultAsync(s => s.Id == id);
    }
}