namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using static Constants;

    internal static class DateTypeExtensions
    {
        internal static string GetFormatFor(DateType dateType)
        {
            switch (dateType)
            {
                case DateType.DateTime: return DateTimeFormat;
                case DateType.Date: return DateFormat;
                case DateType.Time: return TimeFormat;
                default: return string.Empty;
            }
        }
    }
}