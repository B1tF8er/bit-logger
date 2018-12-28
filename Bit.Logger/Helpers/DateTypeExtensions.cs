namespace Bit.Logger.Helpers
{
    using Enums;
    using static Constants;

    internal static class DateTypeExtensions
    {
        internal static string GetFormatFor(DateType dateType)
        {
            switch (dateType)
            {
                case DateType.DateTimeISO: return DateTimeFormat;
                case DateType.Date: return DateFormat;
                case DateType.Time: return TimeFormat;
                case DateType.Default:
                default: return string.Empty;
            }
        }
    }
}