﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Language
    {
        public string Iso6391 { get; set; } = null!;
        public string Name { get; set; } = null!;
        public IReadOnlyCollection<FilterListLanguage> FilterListLanguages { get; private set; } = new HashSet<FilterListLanguage>();
    }

    internal class LanguageTypeConfiguration : IEntityTypeConfiguration<Language>
    {
        public virtual void Configure(EntityTypeBuilder<Language> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));
            builder.HasKey(l => l.Iso6391);
            builder.Property(l => l.Iso6391)
                .IsFixedLength()
                .HasMaxLength(2);
            builder.HasDataJsonFile<Language>();
        }
    }
}
