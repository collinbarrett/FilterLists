using System.Globalization;
using EFCore.NamingConventions.Internal;
using FilterLists.Directory.Domain.Aggregates.FilterLists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.EntityTypeConfigurations;

internal class FilterListTypeConfiguration : IEntityTypeConfiguration<FilterList>
{
    public virtual void Configure(EntityTypeBuilder<FilterList> builder)
    {
        // TODO: register and resolve INameRewriter
        var nr = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);

        builder.Property<int>(nameof(Queries.Entities.FilterList.Id));
        builder.Property("_licenseId")
            .HasColumnName(nr.RewriteName(nameof(Queries.Entities.FilterList.LicenseId)));
        builder.HasOne(f => f.License)
            .WithMany()
            .HasForeignKey("_licenseId");
        builder.Navigation(f => f.Changes)
            .AutoInclude();
        builder.Navigation(f => f.ViewUrls)
            .AutoInclude();
    }
}
