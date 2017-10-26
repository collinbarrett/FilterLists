using FilterLists.Data.Models.Implementations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data.Contexts
{
    public interface IFilterListsDbContext
    {
        DbSet<FilterList> FilterLists { get; set; }
        DbSet<Maintainer> Maintainers { get; set; }
        DbSet<Language> Languages { get; set; }
    }
}