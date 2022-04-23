using System;
using System.Collections.Generic;

namespace FilterLists.Api.Api.Lists.Put.Request;

public record FilterList
{
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public Uri? HomeUrl { get; init; }
    public Uri? OnionUrl { get; init; }
    public Uri? PolicyUrl { get; init; }
    public Uri? SubmissionUrl { get; init; }
    public Uri? IssuesUrl { get; init; }
    public Uri? ForumUrl { get; init; }
    public Uri? ChatUrl { get; init; }
    public string? EmailAddress { get; init; }
    public Uri? DonateUrl { get; init; }
    public IEnumerable<FilterListViewUrl> ViewUrls { get; init; } = new HashSet<FilterListViewUrl>();
    public License License { get; init; } = default!;
    public IEnumerable<Syntax> Syntaxes { get; init; } = new HashSet<Syntax>();
    public IEnumerable<string> LanguageIso6391s { get; init; } = new HashSet<string>();
    public IEnumerable<Maintainer> Maintainers { get; init; } = new HashSet<Maintainer>();
    public IEnumerable<Tag> Tags { get; init; } = new HashSet<Tag>();
    public IEnumerable<string> UpstreamFilterListNames { get; init; } = new HashSet<string>();
    public IEnumerable<string> ForkFilterListNames { get; init; } = new HashSet<string>();
    public IEnumerable<string> IncludedInFilterListNames { get; init; } = new HashSet<string>();
    public IEnumerable<string> IncludesFilterListNames { get; init; } = new HashSet<string>();
    public IEnumerable<string> DependencyFilterListNames { get; init; } = new HashSet<string>();
    public IEnumerable<string> DependentFilterListNames { get; init; } = new HashSet<string>();
}