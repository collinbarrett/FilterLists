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
        protected readonly EmailService EmailService;

        public Service(FilterListsDbContext dbContext) => DbContext = dbContext;

        public Service(FilterListsDbContext dbContext, IConfigurationProvider configurationProvider)
        {
            DbContext = dbContext;
            ConfigurationProvider = configurationProvider;
        }

        public Service(FilterListsDbContext dbContext, IConfigurationProvider configurationProvider,
            EmailService emailService)
        {
            DbContext = dbContext;
            ConfigurationProvider = configurationProvider;
            EmailService = emailService;
        }
    }
}