namespace FilterLists.SharedKernel.Logging.Options
{
    internal class ApplicationInsightsOptions
    {
        public const string Key = "ApplicationInsights";

        public string ServerTelemetryChannelStoragePath { get; init; } = null!;
    }
}
