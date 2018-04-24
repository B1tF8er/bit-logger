namespace Bit.Logger.Samples
{
    using Bit.Logger;
    using Bit.Logger.Config;
    
    class Program
    {
        static ILoggerFactory logger = new Logger();

        static void Main(string[] args)
        {
            logger
                .AddConsoleSource(new Configuration
                {
                    Level = Level.Trace,
                    ShowLevel = false
                })
                .AddDatabaseSource(new Configuration
                {
                    Level = Level.Critical,
                    ShowTime = false,
                })
                .AddFileSource(new Configuration
                {
                    Level = Level.Information,
                    ShowDate = false
                })
                .SampleMessageLogs<Program>()
                .SampleMessageLogs()
                .SampleExceptionLogs<Program>()
                .SampleExceptionLogs()
                .SampleMessageAndExceptionLogs<Program>()
                .SampleMessageAndExceptionLogs();
        }
    }
}
