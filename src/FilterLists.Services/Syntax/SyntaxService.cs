using System.Collections.Generic;
using System.Linq;
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

        private IQueryable<Data.Entities.Syntax> ImplementedSyntaxes =>
            DbContext.Syntaxes.Where(s => s.FilterLists.Any());

        public async Task<IEnumerable<SyntaxDto>> GetAllImplemented() =>
            await ImplementedSyntaxes.ProjectTo<SyntaxDto>(MapConfig)
                                     .ToListAsync();

        public async Task<SyntaxDto> GetImplementedById(int id) =>
            await ImplementedSyntaxes.ProjectTo<SyntaxDto>(MapConfig)
                                     .FirstOrDefaultAsync(s => s.Id == id);
    }
}