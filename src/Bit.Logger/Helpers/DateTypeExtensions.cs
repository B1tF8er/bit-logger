namespace Bit.Logger.Helpers
{
    using Enums;
    using System.Collections.Generic;
    using static Constants.Format;

    internal static class DateTypeExtensions
    {
        private static readonly IDictionary<DateType, string> formats;

        static DateTypeExtensions()
        {
            formats = new Dictionary<DateType, string>
            {
                { DateType.DateTimeIso, DateTimeFormat },
                { DateType.DateIso, DateFormat },
                { DateType.TimeIso, TimeFormat },
            };
        }

        internal static string GetFormatFor(DateType dateType)
        {
            formats.TryGetValue(dateType, out var format);
            return format;
        }
    }
}
