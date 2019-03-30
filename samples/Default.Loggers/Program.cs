using Bit.Logger;
using Bit.Logger.Contract;
using Bit.Logger.Enums;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Default.Loggers
{
    // alias to avoid conflict with Microsoft.Extensions.Configuration
    using LogConfig = Bit.Logger.Config.Configuration;

    class Program
    {
        static void Main(string[] args)
        {
            // Create service collection
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Create service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            try
            {
                // Run app
                serviceProvider.GetService<App>().Run();
            }
            catch (Exception ex)
            {
                Environment.FailFast(ex.Message, ex);
            }
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            // Build logger
            ILogger logger = new Logger()
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
                    ShowLevel = ShowLevel.No,
                    Level = Level.Trace,
                }) 
                // this will log only critical messages to the file
                .AddFileSource(new LogConfig
                {
                    DateTypeFormat = DateType.TimeIso,
                    ShowLevel = ShowLevel.Yes,
                    Level = Level.Critical 
                });

                // IMPORTANT: both the file and the database are created where the assembly is run

            // Build configuration
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            // Add access to generic ILogger
            serviceCollection.AddSingleton(logger);
            // Add access to generic IConfiguration
            serviceCollection.AddSingleton(configuration);
            // Add the App
            serviceCollection.AddTransient<App>();
        }
    }
}
