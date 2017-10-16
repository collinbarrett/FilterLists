using FilterLists.Data.Contexts;
using FilterLists.Data.Models;
using FilterLists.Data.Repositories.Implementations;

namespace FilterLists.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FilterListsDbContext filterListsDbContext)
        {
            filterListsDbContext.Database.EnsureCreated();
            InitializeList(filterListsDbContext);
        }

        private static void InitializeList(FilterListsDbContext filterListsDbContext)
        {
            var listRepository = new ListRepository(filterListsDbContext);
            if (listRepository.Any())
            {
                listRepository.DeleteAll();
            }
            var lists = new List[]
            {
                //TODO: populate from csv or json
            };
            foreach (var list in lists)
            {
                listRepository.Create(list);
            }
        }
    }
}