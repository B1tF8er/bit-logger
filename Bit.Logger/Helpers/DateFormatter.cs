namespace Bit.Logger.Helpers
{
    using Enums;
    using Config;
    using System;
    using static FormatProviders.FormatterStrategy.FormatterStrategyExtensions;

    internal static class DateFormatter
    {
        internal static string GetFormattedDateFrom(DateType dateTypeFormat)
            => DateTime.Now.ApplyFormat(dateTypeFormat.ToString().ToLower());
    }
}