namespace Default.Loggers
{
    using Bit.Logger;
    using Bit.Logger.Contract;
    using Bit.Logger.Enums;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using static Constants.Path;
    using static LogConfigurationExtensions;

    internal static class Startup
    {
        internal static ServiceProvider ServiceProvider { get; }

        static Startup() => ServiceProvider = new ServiceCollection()
            .AddServices()
            .BuildServiceProvider();

        private static ServiceCollection AddServices(this ServiceCollection serviceCollection)
        {
            serviceCollection
                .AddSingleton(Logger())
                .AddSingleton(Configuration())
                .AddTransient<App>();

            return serviceCollection;
        }

        private static ILogger Logger()
        {
            var consoleConfiguration = CreateConfiguration(DateType.DateTimeIso, ShowLevel.Yes, Level.Trace);
            var databaseConfiguration = CreateConfiguration(DateType.DateIso, ShowLevel.Yes);
            var fileConfiguration = CreateConfiguration(DateType.TimeIso, ShowLevel.No, Level.Critical);

            databaseConfiguration.DatabaseLogLocation = @"D:\Logs\Database";
            fileConfiguration.FileLogLocation = @"D:\Logs\File";

            var logger = new Logger()
                .AddConsoleSource(consoleConfiguration)
                .AddDatabaseSource(databaseConfiguration)
                .AddFileSource(fileConfiguration);

            return logger;
        }

        private static IConfiguration Configuration() => new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile(AppSettingsPath, optional: true, reloadOnChange: true)
            .Build();
    }
}
