namespace Bit.Logger.Helpers
{
    using Bit.Logger.Config;
    using System;
    using static Bit.Logger.FormatProviders.FormatterStrategy.FormatterStrategyExtensions;

    internal static class DateFormatter
    {
        internal static string GetFormattedDateFrom(DateType dateTypeFormat)
            => DateTime.Now.ApplyFormat(dateTypeFormat.ToString().ToLower());
    }
}