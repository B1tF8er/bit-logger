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
                case DateType.DateTimeIso: format = DateTimeFormat; break;
                case DateType.DateIso: format = DateFormat; break;
                case DateType.TimeIso: format = TimeFormat; break;
                case DateType.Default:
                default: break;
            }

            return format;
        }
    }
}