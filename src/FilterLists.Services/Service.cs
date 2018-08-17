using AutoMapper;
using FilterLists.Data;
using JetBrains.Annotations;

namespace FilterLists.Services
{
    [UsedImplicitly]
    public class Service
    {
        protected readonly FilterListsDbContext DbContext;
        protected readonly IConfigurationProvider MapConfig;

        public Service(FilterListsDbContext dbContext) => DbContext = dbContext;

        public Service(FilterListsDbContext dbContext, IConfigurationProvider mapConfig)
        {
            DbContext = dbContext;
            MapConfig = mapConfig;
        }
    }
}