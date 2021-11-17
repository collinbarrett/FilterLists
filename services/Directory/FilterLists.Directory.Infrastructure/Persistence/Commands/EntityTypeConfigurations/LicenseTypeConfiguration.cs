using FilterLists.Directory.Domain.Aggregates.Licenses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.EntityTypeConfigurations;

internal class LicenseTypeConfiguration : IEntityTypeConfiguration<License>
{
    public virtual void Configure(EntityTypeBuilder<License> builder)
    {
        builder.Property<int>(nameof(Queries.Entities.License.Id));
    }
}
