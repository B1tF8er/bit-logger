namespace Bit.Logger.Loggers.Console
{
    using Arguments;
    using Config;
    using BulkWriters;
    using System;
    using static Helpers.LogArgumentsExtensions;

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
                ?.Write(BulkWriter.ToConsole, kv => kv.Value)
                .Clear();
        }
    }
}