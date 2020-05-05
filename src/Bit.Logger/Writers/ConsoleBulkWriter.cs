namespace Bit.Logger.Writers
{
    using System;
    using System.Collections.Generic;
    using static Helpers.ConsoleColorSelector;
    using static Helpers.StringExtensions;

    internal class ConsoleBulkWriter : IConsoleBulkWriter
    {
        public void ToConsole(IEnumerable<string> logs)
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
