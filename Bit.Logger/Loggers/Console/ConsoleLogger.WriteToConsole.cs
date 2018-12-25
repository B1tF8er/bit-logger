namespace Bit.Logger.Loggers.Console
{
    using Arguments;
    using Config;
    using Enums;
    using System;
    using static Helpers.ConsoleColorSelector;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        private void WriteToConsole(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

            Console.ForegroundColor = logArguments.Level.GetForegroundColor();
            Console.WriteLine(CreateLogWith(logArguments));
            Console.ResetColor();
        }

        private string CreateLogWith(LogArguments logArguments)
        {
            return string.Format(Configuration.FormatProvider, Configuration.Format,
                logArguments.Level,
                DateTime.Now,
                logArguments.ClassName,
                logArguments.MethodName,
                logArguments.Message,
                logArguments.Exception
            ).Trim();
        }
    }
}