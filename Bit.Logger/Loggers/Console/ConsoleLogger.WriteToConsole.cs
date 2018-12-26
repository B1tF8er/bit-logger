namespace Bit.Logger.Loggers.Console
{
    using Arguments;
    using Config;
    using System;
    using System.Collections.Generic;
    using static Helpers.ConsoleColorSelector;
    using static Helpers.LogArgumentsExtensions;
    using static Helpers.StringExtensions;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        private void WriteToConsole(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

            LogBuffer
                .Add(logArguments.ToStringLogUsing(Configuration))
                .Validate()
                ?.Write(BulkWriteToConsole, kv => kv.Value)
                .Clear();
        }

        private void BulkWriteToConsole(IEnumerable<string> logs)
        {
            foreach (var log in logs)
            {
                Console.ForegroundColor = log.GetLevel().GetForegroundColor();
                Console.WriteLine(log);
                Console.ResetColor();
            }
        }
    }
}