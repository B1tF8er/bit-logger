namespace Bit.Logger.Writers
{
    using System;
    using System.Collections.Generic;
    using static Helpers.ConsoleColorSelector;
    using static Helpers.StringExtensions;

    internal static class ConsoleBulkWriter
    {
        internal static void ToConsole(IEnumerable<string> logs)
        {
            foreach (var log in logs)
            {
                Console.ForegroundColor = log.GetLevel().GetForegroundColor();
                Console.WriteLine(log);
            }

            Console.ResetColor();
        }
    }
}
