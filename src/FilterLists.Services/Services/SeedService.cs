using System.Collections.Generic;
using AutoMapper;
using FilterLists.Data;

namespace FilterLists.Services.Services
{
    public class SeedService
    {
        private readonly FilterListsDbContext filterListsDbContext;
        private readonly IMapper mapper;

        public SeedService(FilterListsDbContext filterListsDbContext, IMapper mapper)
        {
            this.filterListsDbContext = filterListsDbContext;
            this.mapper = mapper;
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return mapper.Map<IEnumerable<T>>(filterListsDbContext.Set<T>());
        }
    }
}