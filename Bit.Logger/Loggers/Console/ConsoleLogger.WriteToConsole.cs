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
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

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