using FilterLists.Data.Contracts;
using FilterLists.Models;

namespace FilterLists.Data
{
    public class ListRepository : Repository<List>, IListRepository
    {
        public ListRepository(FilterListsContext context) : base(context)
        {
        }
    }
}