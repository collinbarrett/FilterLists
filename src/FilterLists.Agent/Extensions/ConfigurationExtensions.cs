using System;
using Microsoft.Extensions.Configuration;

namespace FilterLists.Agent.Extensions
{
    public static class ConfigurationExtensions
    {
        public static TSettings GetSettings<TSettings>(this IConfiguration configuration) where TSettings : new()
        {
            var settings = new TSettings();
            configuration.GetSection<TSettings>().Bind(settings);
            return settings;
        }

        public static IConfigurationSection GetSection<TSettings>(this IConfiguration configuration)
        {
            return configuration.GetSection(typeof(TSettings).Name.Replace("Settings", "", StringComparison.Ordinal));
        }
    }
}