﻿using FilterLists.Api.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.EntityFrameworkCore.Entities;

public record Language
{
    public int Id { get; init; }
    public string Iso6391 { get; init; } = default!;
    public string Name { get; init; } = default!;
    public IEnumerable<FilterListLanguage> FilterListLanguages { get; init; } = new HashSet<FilterListLanguage>();
}

internal class LanguageTypeConfiguration : IEntityTypeConfiguration<Language>
{
    public virtual void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.Property(l => l.Iso6391)
            .IsFixedLength()
            .HasMaxLength(2);
        builder.HasIndex(l => l.Iso6391)
            .IsUnique();
        builder.HasIndex(l => l.Name)
            .IsUnique();
        builder.HasDataJsonFile<Language>();
    }
}