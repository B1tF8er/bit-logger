namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using Bit.Logger.Loggers.Arguments;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        private void WriteToConsole(LogArguments logArguments)
        {
            if (Configuration.Level <= logArguments.Level)
            {
                Console.WriteLine(
                    string.Format(Configuration.FormatProvider, Configuration.Format,
                        logArguments.Level,
                        DateTime.Now,
                        logArguments.ClassName,
                        logArguments.MethodName,    
                        logArguments.Message,    
                        logArguments.Exception
                    )
                );
            }
        }
    }
}