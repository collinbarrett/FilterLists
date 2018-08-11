using System.Threading.Tasks;
using FilterLists.Data;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services
{
    [UsedImplicitly]
    public class RuleService : Service
    {
        public RuleService(FilterListsDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<int> GetCountAll() =>
            await DbContext.Rules.AsNoTracking().CountAsync();
    }
}