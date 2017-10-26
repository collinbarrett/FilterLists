using FilterLists.Data.Models.Implementations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data.Contexts
{
    public interface IFilterListsDbContext
    {
        DbSet<Maintainer> Maintainers { get; set; }
        DbSet<FilterList> FilterLists { get; set; }
        DbSet<Language> Languages { get; set; }
    }
}