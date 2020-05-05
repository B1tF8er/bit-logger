namespace Bit.Logger.Helpers
{
    using Enums;
    using System;
    using System.Collections.Generic;

    internal static class ConsoleColorSelector
    {
        private static readonly IDictionary<Level, ConsoleColor> consoleColors =
            consoleColors = new Dictionary<Level, ConsoleColor>
            {
                { Level.Trace, ConsoleColor.DarkMagenta },
                { Level.Debug, ConsoleColor.Green },
                { Level.Verbose, ConsoleColor.DarkCyan },
                { Level.Information, ConsoleColor.Gray },
                { Level.Warning, ConsoleColor.Yellow },
                { Level.Error, ConsoleColor.Red },
                { Level.Critical, ConsoleColor.DarkRed },
                { Level.None, ConsoleColor.White },
            };

        internal static ConsoleColor GetForegroundColor(this Level level)
        {
            consoleColors.TryGetValue(level, out var consoleColor); 
            return consoleColor;
        }
    }
}
