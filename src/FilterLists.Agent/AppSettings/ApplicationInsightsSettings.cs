using JetBrains.Annotations;

namespace FilterLists.Agent.AppSettings
{
    public class ApplicationInsightsSettings
    {
        public string InstrumentationKey { get; [UsedImplicitly] set; }
    }
}