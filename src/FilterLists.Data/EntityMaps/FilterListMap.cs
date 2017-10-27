using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data.EntityMaps
{
    public class FilterListMap : IEntityMap
    {
        public FilterListMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilterList>()
                .Property(b => b.CreatedDateUtc)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}