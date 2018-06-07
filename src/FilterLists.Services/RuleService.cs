using System.Linq;
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
            DbContext = dbContext;
        }

        public async Task<int> GetCountAllActiveRules() => await DbContext
                                                                 .SnapshotRules.AsNoTracking()
                                                                 .Where(x => x.RemovedBySnapshotId == null)
                                                                 .GroupBy(x => x.RuleId)
                                                                 .CountAsync();
    }
}