﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListLanguage
    {
        public int FilterListId { get; private set; }
        public FilterList FilterList { get; private set; } = null!;
        public string Iso6391 { get; private set; } = null!;
        public Language Language { get; private set; } = null!;
    }

    internal class FilterListLanguageTypeConfiguration : IEntityTypeConfiguration<FilterListLanguage>
    {
        public virtual void Configure(EntityTypeBuilder<FilterListLanguage> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));
            builder.ToTable(nameof(FilterListLanguage) + "s");
            builder.HasKey(fll => new {fll.FilterListId, fll.Iso6391});
            builder.HasDataJsonFile<FilterListLanguage>();
        }
    }
}