# Logger for .NET Core #

Logger for .NET Core Apps that enables logging to different sources

> `One logger to log them all`

## Console ##

If the code that implements the logger uses a console messages can be sent to it

## Database ##

A SQLite database is created to save the records in the path where the assembly is run

## File ##

A file is created every hour to keep small files in the path where the assembly is run

## Custom ##

You can create custom sources to send the messages to a different output of your preference

## Configurable ##

All the provided sources and the ones you may create can be configured to only show specific data according to the needs of your business

## How to use with default sources ##

```csharp
class Program
{
    // Inject in a service provider
    static void Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);

        // Create service provider
        var serviceProvider = serviceCollection.BuildServiceProvider();

        // Run app
        serviceProvider.GetService<Test>().It();
    }

    private void ConfigureServices()
    {
        // Build logger
        ILogger logger = new Logger()
            .AddConsoleSource()
            .AddDatabaseSource()
            .AddFileSource();

        // Add access to generic ILogger
        serviceCollection.AddSingleton(logger);

        // Add the Test class
        serviceCollection.AddTransient<Test>();
    }
}

// Somewhere else in the code

internal class Test
{
    private readonly ILogger logger;

    internal Test(ILogger logger) => this.logger = logger;

    internal void It() => logger.Information("sample");
}

// Call it
var args = new string[] {};
Program.Main(args);

// this should produce an output to a file, database and console and display a message like this
// <INFORMATION> 2019-03-06 23:02:56 [Test::It] sample
```

## How the Log Levels work ##

```csharp

// This is the Level enum
public enum Level
{
    Trace = 0,
    Debug = 1,
    Verbose = 2,
    Information = 3,
    Warning = 4,
    Error = 5,
    Critical = 6,
    None = 7
}

public void Test()
{
    var consoleConfiguration = new Configuration
    {
        Level = Level.Trace // Do not ignore any level and log all messages
    };

    var databaseConfiguration = new Configuration
    {
        Level = Level.Warning // Ignore any lower levels and only log messages equal or greater than Warning
    };

    var fileConfiguration = new Configuration
    {
        Level = Level.Critical // Ignore any lower levels and only log Critical messages 
    };

    // Build logger
    ILogger logger = new Logger()
        .AddConsoleSource(consoleConfiguration)
        .AddDatabaseSource(databaseConfiguration)
        .AddFileSource(fileConfiguration);

    logger.Trace("test"); // this will only be sent to the console
    logger.Warning("test"); // this will be sent to the console and the database
    logger.Critical("test"); // this will be sent to the console, the database and the file
}
```

## See the samples ##

[Console](https://github.com/B1tF8er/bit-logger/tree/master/samples/Default.Loggers) application with the 3 default loggers configured
