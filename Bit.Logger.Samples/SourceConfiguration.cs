namespace Bit.Logger.Samples
{
    using Bit.Logger.Config;
    using System;
    using System.Collections.Generic;

    internal static class Config
    {
        internal static Func<Configuration> CreateConsoleConfiguration = () => new Configuration
        {
            Level = Level.Trace,
            ShowLevel = false
        };

        internal static Func<Configuration> CreateDatabaseConfiguration = () => new Configuration
        {
            Level = Level.Critical,
            ShowTime = false
        };
        internal static Func<Configuration> CreateFileConfiguration = () => new Configuration
        {
            Level = Level.Information,
            ShowDate = false
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