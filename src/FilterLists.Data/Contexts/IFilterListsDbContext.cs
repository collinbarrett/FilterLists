using FilterLists.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data.Contexts
{
    public interface IFilterListsDbContext
    {
        DbSet<List> List { get; set; }
        DbSet<TableCsv> TableCsv { get; set; }
    }
}