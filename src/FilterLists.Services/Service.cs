using AutoMapper;
using FilterLists.Data;
using JetBrains.Annotations;

namespace FilterLists.Services
{
    [UsedImplicitly]
    public class Service
    {
        protected readonly FilterListsDbContext DbContext;
        protected readonly IMapper Mapper;

        public Service(FilterListsDbContext dbContext) => DbContext = dbContext;

        public Service(FilterListsDbContext dbContext, IMapper mapper)
        {
            DbContext = dbContext;
            Mapper = mapper;
        }
    }
}