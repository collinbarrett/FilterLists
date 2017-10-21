using FilterLists.Data.Models.Implementations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data.Contexts
{
    public interface IFilterListsDbContext
    {
        DbSet<List> List { get; set; }
        DbSet<TableCsv> TableCsv { get; set; }
    }
}