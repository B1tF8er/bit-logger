namespace Bit.Logger.Helpers
{
    using Enums;
    using System;

    internal static class ConsoleColorSelector
    {
        internal static ConsoleColor GetForegroundColor(this Level level)
        {
            var consoleColor = ConsoleColor.White;

            switch (level)
            {
                case Level.Trace: consoleColor = ConsoleColor.DarkMagenta; break;
                case Level.Debug: consoleColor = ConsoleColor.Green; break;
                case Level.Verbose: consoleColor = ConsoleColor.DarkCyan; break;
                case Level.Information: consoleColor = ConsoleColor.Gray; break;
                case Level.Warning: consoleColor = ConsoleColor.Yellow; break;
                case Level.Error: consoleColor = ConsoleColor.Red; break;
                case Level.Critical: consoleColor = ConsoleColor.DarkRed; break;
            }

            return consoleColor;
        }
    }
}