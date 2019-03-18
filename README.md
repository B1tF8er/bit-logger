[![Build status](https://ci.appveyor.com/api/projects/status/qgv3t8hq7c5i659h/branch/master?svg=true)](https://ci.appveyor.com/project/B1tF8er/bit-logger/branch/master)
[![Coverage Status](https://coveralls.io/repos/github/B1tF8er/bit-logger/badge.svg?branch=master)](https://coveralls.io/github/B1tF8er/bit-logger?branch=master)
[![NuGet](https://img.shields.io/nuget/v/Bit.Logger.svg)](https://www.nuget.org/packages/Bit.Logger/1.0.6)
[![Nuget](https://img.shields.io/nuget/dt/Bit.Logger.svg)](https://www.nuget.org/packages/Bit.Logger)

# Logger for .NET Core
Logger for .NET Core Apps that enables logging to different sources
> `One logger to log them all`

## Console
If the code that implements the logger uses a console messages can be sent to it

## Database
A SQLite database is created to save the records in the path where the assembly is run

## File
A file is created every hour to keep small files in the path where the assembly is run

## Custom
You can create custom sources to send the messages to a different output of your preference

### Configurable
All the provided sources and the ones you may create can be configured to only show specific data according to the needs of your business


### How to use with default sources

```csharp
// Inject in a service provider
private void AddServices()
{
    services = new ServiceCollection();
    services.AddSingleton<ILogger, Logger>();
}

private void ConfigureLogger()
{
    var logger = serviceProvider.GetService<ILogger>();
    // Here we set the 3 default sources
    logger.AddConsoleSource() // to send messages to the console
        .AddDatabaseSource() // to send messages to a SQLite database that is created where the assembly is run 
        .AddFileSource(); // to send messages to a file that is created every hour where the assembly is run
}

// Somewhere else in the code

internal class Test
{
    private readonly ILogger logger;

    internal Test(ILogger logger) => this.logger = logger;

    internal void It() => logger.Information("sample");
}

// Call it

var test = new Test();
test.It();
```
this should produce an output to a `file`, `database` and `console` and display a message like this

> `<INFORMATION> 2019-03-06 23:02:56 [Test::It] sample`

