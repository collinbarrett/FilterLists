using FilterLists.Data.Models.Implementations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data.Contexts
{
    public interface IFilterListsDbContext
    {
        DbSet<FilterList> FilterList { get; set; }
    }
}