namespace Bit.Logger.Samples
{
    using Bit.Logger;
    using static SourceConfiguration;

    class Program
    {
        static ILoggerFactory logger = new Logger();

        static void Main(string[] args)
        {
            logger
                .AddConsoleSource(CreateConsoleConfiguration())
                .AddDatabaseSource(CreateDatabaseConfiguration())
                .AddFileSource(CreateFileConfiguration())
                .AddSource(CreateCustomConsoleSource())
                .AddSources(CreateCustomConsoleSources());

            // this should be done using a DI container LOL!!
            var sample = new Sample(logger);

            sample.BasicTest();

            sample.AllPossibleLevels();
        }
    }
}
