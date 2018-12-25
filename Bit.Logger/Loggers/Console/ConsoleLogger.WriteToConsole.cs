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

            Console.WriteLine(CreateLogWith(logArguments));
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