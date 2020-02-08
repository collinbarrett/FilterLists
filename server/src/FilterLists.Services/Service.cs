using AutoMapper;
using FilterLists.Data;
using JetBrains.Annotations;

namespace FilterLists.Services
{
    [UsedImplicitly]
    public abstract class Service
    {
        protected readonly FilterListsDbContext DbContext;
        protected readonly IConfigurationProvider MapConfig;

        protected Service(FilterListsDbContext dbContext) => DbContext = dbContext;

        protected Service(FilterListsDbContext dbContext, IConfigurationProvider mapConfig)
        {
            DbContext = dbContext;
            MapConfig = mapConfig;
        }
    }
}