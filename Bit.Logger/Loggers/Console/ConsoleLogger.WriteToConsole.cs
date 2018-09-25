namespace Bit.Logger.Loggers.Console
{
    using Arguments;
    using Config;
    using System;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        private void WriteToConsole(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

            var log = string.Format(Configuration.FormatProvider, Configuration.Format,
                logArguments.Level,
                DateTime.Now,
                logArguments.ClassName,
                logArguments.MethodName,    
                logArguments.Message,    
                logArguments.Exception
            );

            Console.WriteLine(log);
        }
    }
}