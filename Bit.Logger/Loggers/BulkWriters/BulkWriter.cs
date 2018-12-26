namespace Bit.Logger.Loggers.BulkWriters
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using static Helpers.ConsoleColorSelector;
    using static Helpers.EnumerableExtensions;
    using static Helpers.StringExtensions;
    using static Helpers.LogPathResolver;

    internal static class BulkWriter
    {
        internal static void ToConsole(IEnumerable<string> logs)
        {
            foreach (var log in logs)
            {
                Console.ForegroundColor = log.GetLevel().GetForegroundColor();
                Console.WriteLine(log);
                Console.ResetColor();
            }
        }

        internal static async void ToDatabaseAsync(IEnumerable<Log> logs)
        {
            using (var context = new LoggingContext())
                await context.Logs.AddRangeAsync(logs);
        }

        internal static async void ToFileAsync(IEnumerable<string> logs)
        {
            using (var logWriter = new StreamWriter(CurrentLogPath(DateTime.Now), true, Encoding.UTF8))
                await logWriter.WriteAsync(logs.ToAppendedString());
        }
    }
}