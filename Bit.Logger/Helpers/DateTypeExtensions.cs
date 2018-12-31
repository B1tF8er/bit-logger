namespace Bit.Logger.Helpers
{
    using Enums;
    using static Constants;

    internal static class DateTypeExtensions
    {
        internal static string GetFormatFor(DateType dateType)
        {
            var format = string.Empty;

            switch (dateType)
            {
                case DateType.DateTimeISO: format = DateTimeFormat; break;
                case DateType.Date: format = DateFormat; break;
                case DateType.Time: format = TimeFormat; break;
                case DateType.Default:
                default: break;
            }

            return format;
        }
    }
}