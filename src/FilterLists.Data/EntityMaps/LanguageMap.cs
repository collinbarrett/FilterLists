using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data.EntityMaps
{
    public class LanguageMap : IEntityMap
    {
        public LanguageMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>()
                .Property(b => b.CreatedDateUtc)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}