namespace FilterLists.Directory.Api.Cors;

internal record CorsOptions
{
    public const string Cors = "Cors";
    public string[] AllowedOrigins { get; init; } = [];
    public StagingOriginPatternsSettings? StagingOriginPatterns { get; init; }
}

/// <summary>
///     Azure Static Web Apps staging environment origin patterns.
/// </summary>
internal record StagingOriginPatternsSettings
{
    public required string Start { get; init; }
    public required string End { get; init; }
}