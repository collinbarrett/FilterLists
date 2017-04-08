using FilterLists.Data.Contracts.Contexts;
using FilterLists.Models;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data.Contexts
{
    public class FilterListsDbContext : DbContext, IFilterListsDbContext
    {
        public FilterListsDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public FilterListsDbContext()
        {
        }

        public DbSet<List> Lists { get; set; }
    }
}