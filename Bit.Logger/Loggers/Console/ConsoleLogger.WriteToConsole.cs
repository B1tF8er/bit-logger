namespace Bit.Logger.Loggers.Console
{
    using Arguments;
    using Config;
    using System;
    using static Helpers.ConsoleColorSelector;
    using static Helpers.LogArgumentsExtensions;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        private void WriteToConsole(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

            Console.ForegroundColor = logArguments.Level.GetForegroundColor();
            Console.WriteLine(logArguments.ToStringLogUsing(Configuration));
            Console.ResetColor();
        }
    }
}