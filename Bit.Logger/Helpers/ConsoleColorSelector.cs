namespace Bit.Logger.Helpers
{
    using Enums;
    using System;

    internal static class ConsoleColorSelector
    {
        internal static ConsoleColor GetForegroundColor(this Level level)
        {
            switch (level)
            {
                case Level.Trace: return ConsoleColor.DarkMagenta;
                case Level.Debug: return ConsoleColor.Green;
                case Level.Verbose: return ConsoleColor.DarkCyan;
                case Level.Information: return ConsoleColor.Gray;
                case Level.Warning: return ConsoleColor.Yellow;
                case Level.Error: return ConsoleColor.Red;
                case Level.Critical: return ConsoleColor.DarkRed;
                default: return ConsoleColor.White;
            }
        }
    }
}