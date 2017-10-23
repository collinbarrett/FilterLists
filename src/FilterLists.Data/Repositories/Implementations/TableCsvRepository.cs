using System.Collections.Generic;
using System.Linq;
using FilterLists.Data.Contexts;
using FilterLists.Data.Models.Contracts;
using FilterLists.Data.Repositories.Contracts;

namespace FilterLists.Data.Repositories.Implementations
{
    public class TableCsvRepository : ITableCsvRepository
    {
        private readonly IFilterListsDbContext filterListsDbContext;

        public TableCsvRepository(FilterListsDbContext filterListsDbContext)
        {
            this.filterListsDbContext = filterListsDbContext;
        }

        public IEnumerable<ITableCsv> GetAll()
        {
            return filterListsDbContext.TableCsv.AsEnumerable();
        }

        public string GetUrlByName(string name)
        {
            return filterListsDbContext.TableCsv.FirstOrDefault(x => x.Name == name).Url;
        }
    }
}