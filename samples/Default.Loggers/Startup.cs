using Bit.Logger;
using Bit.Logger.Contract;
using Bit.Logger.Enums;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Default.Loggers
{
    // alias to avoid conflict with Microsoft.Extensions.Configuration
    using LogConfig = Bit.Logger.Config.Configuration;

    internal static class Startup
    {
        private static readonly ServiceCollection serviceCollection;

        internal static ServiceProvider ServiceProvider { get; }

        static Startup()
        {
            serviceCollection = new ServiceCollection();
            AddServices();
            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        private static void AddServices()
        {
            // Add access to generic ILogger
            serviceCollection.AddSingleton(BuildLogger());
            // Add access to generic IConfiguration
            serviceCollection.AddSingleton(BuildConfiguration());
            // Add the App
            serviceCollection.AddTransient<App>();
        }

        private static ILogger BuildLogger()
        {
            // IMPORTANT: both the file and the database are created where the assembly is run
            // Build logger
            return new Logger()
                // this will log messages from trace which is the lowest level to critical which is the highest
                .AddConsoleSource(new LogConfig
                {
                    DateTypeFormat = DateType.DateTimeIso,
                    ShowLevel = ShowLevel.Yes,
                    Level = Level.Trace
                })
                // this will default the level to information to the logs.db SQLite database
                .AddDatabaseSource(new LogConfig
                {
                    DateTypeFormat = DateType.DateIso,
                    ShowLevel = ShowLevel.No
                })
                // this will log only critical messages to the file
                .AddFileSource(new LogConfig
                {
                    DateTypeFormat = DateType.TimeIso,
                    ShowLevel = ShowLevel.Yes,
                    Level = Level.Critical
                });
        }

        private static IConfiguration BuildConfiguration()
        {
            // Build configuration
            return new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
        }
    }
}
