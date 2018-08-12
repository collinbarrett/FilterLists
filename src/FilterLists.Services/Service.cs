using AutoMapper;
using FilterLists.Data;
using JetBrains.Annotations;

namespace FilterLists.Services
{
    [UsedImplicitly]
    public class Service
    {
        protected readonly IConfigurationProvider ConfigurationProvider;
        protected readonly FilterListsDbContext DbContext;

        public Service(FilterListsDbContext dbContext) => DbContext = dbContext;

        public Service(FilterListsDbContext dbContext, IConfigurationProvider configurationProvider)
        {
            DbContext = dbContext;
            ConfigurationProvider = configurationProvider;
        }
    }
}