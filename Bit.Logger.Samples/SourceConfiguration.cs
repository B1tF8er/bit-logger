namespace Bit.Logger.Samples
{
    using Bit.Logger.Config;
    using Bit.Logger.Enums;
    using System;
    using System.Collections.Generic;
    using static Bit.Logger.Enums.DateType;

    internal static class SourceConfiguration
    {
        internal static Func<Configuration> CreateConsoleConfiguration = () => new Configuration
        {
            Level = Level.Trace,
            ShowLevel = false
        };

        internal static Func<Configuration> CreateDatabaseConfiguration = () => new Configuration
        {
            Level = Level.Critical,
            DateTypeFormat = Date
        };
        
        internal static Func<Configuration> CreateFileConfiguration = () => new Configuration
        {
            Level = Level.Information,
            DateTypeFormat = Time
        };

        internal static Func<CustomConsoleSource> CreateCustomConsoleSource = () => new CustomConsoleSource(new Configuration
        {
            Level = Level.Trace
        });

        internal static Func<IEnumerable<CustomConsoleSource>> CreateCustomConsoleSources = () => new List<CustomConsoleSource>
        {
            new CustomConsoleSource(new Configuration
            {
                Level = Level.Critical
            }),
            new CustomConsoleSource(new Configuration
            {
                Level = Level.Error
            }),
            new CustomConsoleSource()
        };
    }
}
