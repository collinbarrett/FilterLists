using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data.EntityMaps
{
    public class MaintainerMap : IEntityMap
    {
        public MaintainerMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Maintainer>()
                .Property(b => b.CreatedDateUtc)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}