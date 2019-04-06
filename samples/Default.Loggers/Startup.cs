using Bit.Logger;
using Bit.Logger.Contract;
using Bit.Logger.Enums;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using static Default.Loggers.LogConfigurationExtensions;

namespace Default.Loggers
{
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
            serviceCollection.AddSingleton(BuildLogger());
            serviceCollection.AddSingleton(BuildConfiguration());
            serviceCollection.AddTransient<App>();
        }

        private static ILogger BuildLogger() => new Logger()
            .AddConsoleSource(CreateConfiguration(DateType.DateTimeIso, ShowLevel.Yes, Level.Trace))
            .AddDatabaseSource(CreateConfiguration(DateType.DateIso, ShowLevel.No))
            .AddFileSource(CreateConfiguration(DateType.TimeIso, ShowLevel.Yes, Level.Critical));

        private static IConfiguration BuildConfiguration() => new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
    }
}
