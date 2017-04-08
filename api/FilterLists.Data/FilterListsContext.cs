using FilterLists.Models;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data
{
    public class FilterListsContext : DbContext
    {
        public FilterListsContext(DbContextOptions options)
            : base(options)
        {
        }

        public FilterListsContext()
        {
        }

        public DbSet<List> Lists { get; set; }
    }
}