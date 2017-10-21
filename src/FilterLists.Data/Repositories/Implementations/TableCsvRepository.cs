using System.Collections.Generic;
using System.Linq;
using FilterLists.Data.Contexts;
using FilterLists.Data.Models.Contracts;
using FilterLists.Data.Repositories.Contracts;

namespace FilterLists.Data.Repositories.Implementations
{
    public class TableCsvRepository : ITableCsvRepository
    {
        private readonly IFilterListsDbContext _filterListsDbContext;

        public TableCsvRepository(FilterListsDbContext filterListsDbContext)
        {
            _filterListsDbContext = filterListsDbContext;
        }

        public IEnumerable<ITableCsv> GetAll()
        {
            return _filterListsDbContext.TableCsv.AsEnumerable();
        }

        public string GetUrlByName(string name)
        {
            return _filterListsDbContext.TableCsv.FirstOrDefault(x => x.Name == name).Url;
        }
    }
}