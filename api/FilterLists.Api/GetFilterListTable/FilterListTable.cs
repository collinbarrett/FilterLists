using System.Collections.Generic;
using FilterLists.Api.GetFilterListSummaries;
using FilterLists.Api.GetLanguages;
using FilterLists.Api.GetLicenses;
using FilterLists.Api.GetMaintainers;
using FilterLists.Api.GetSoftware;
using FilterLists.Api.GetSyntaxes;
using FilterLists.Api.GetTags;
using FilterLists.Api.OData;

namespace FilterLists.Api.GetFilterListTable;

public record FilterListTable
{
    public OData<List<FilterListSummary>> FilterLists { get; init; } = new();
    public List<Language> Languages { get; init; } = new();
    public List<License> Licenses { get; init; } = new();
    public List<Maintainer> Maintainers { get; init; } = new();
    public List<Software> Software { get; init; } = new();
    public List<Syntax> Syntaxes { get; init; } = new();
    public List<Tag> Tags { get; init; } = new();
}