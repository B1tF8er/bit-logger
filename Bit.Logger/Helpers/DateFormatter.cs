namespace Bit.Logger.Helpers
{
    using Bit.Logger.Config;
    using System;
    using static Bit.Logger.FormatProviders.FormatterStrategy.FormatterExtensions;

    internal static class DateFormatter
    {
        internal static string GetDateFormatFrom(Configuration Configuration)
        {
            var now = DateTime.Now;

            if (Configuration.ShowDate && Configuration.ShowTime)
                return now.ApplyFormat("datetime");
            else if (Configuration.ShowDate)
                return now.ApplyFormat("date");
            else if (Configuration.ShowTime)
                return now.ApplyFormat("time");
            else
                return now.ToLongDateString();
        }
    }
}