using FilterLists.Data;
using JetBrains.Annotations;

namespace FilterLists.Services
{
    [UsedImplicitly]
    public class Service
    {
        protected FilterListsDbContext DbContext;

        public Service(FilterListsDbContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}