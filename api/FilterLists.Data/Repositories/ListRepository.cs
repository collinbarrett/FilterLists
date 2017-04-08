using FilterLists.Data.Contexts;
using FilterLists.Data.Contracts.Repositories;
using FilterLists.Models;

namespace FilterLists.Data.Repositories
{
    public class ListRepository : Repository<List>, IListRepository
    {
        public ListRepository(FilterListsDbContext context) : base(context)
        {
        }
    }
}