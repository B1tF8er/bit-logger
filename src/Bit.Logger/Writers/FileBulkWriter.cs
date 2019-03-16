namespace Bit.Logger.Writers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using static Helpers.EnumerableExtensions;
    using static Helpers.LogPathResolver;

    internal static class FileBulkWriter
    {
        internal static async void ToFileAsync(IEnumerable<string> logs)
        {
            using (var logWriter = new StreamWriter(CurrentLogPath(DateTime.Now), true, Encoding.UTF8))
                await logWriter.WriteAsync(logs.ToAppendedString());
        }
    }
}
