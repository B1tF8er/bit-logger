namespace Bit.Logger.FormatProviders
{
    using System;
    using System.Linq;
    using static Bit.Logger.FormatProviders.Constants;

    internal static class FormatterExtensions
    {
        internal static string ApplyFormat(this object argument, string format)
        {
            if (format == null)
                return argument?.ToString() ?? string.Empty;

            if (format == "level")
                return argument?.ToString().ApplyLevelFormat() ?? string.Empty;

            if (format == "datetime")
            {
                var datetime = Convert.ToDateTime(argument);
                return datetime.ApplyDateFormat(DateType.DateTime);
            }

            if (format == "date")
            {
                var date = Convert.ToDateTime(argument);
                return date.ApplyDateFormat(DateType.Date);
            }

            if (format == "time")
            {
                var time = Convert.ToDateTime(argument);
                return time.ApplyDateFormat(DateType.Time);
            }

            if (format == "caller")
                return argument?.ToString().ApplyCallerFormat() ?? string.Empty;

            if (format == "exception")
            {
                var exception = argument as Exception;
                return exception?.ApplyExceptionFormat() ?? string.Empty;
            }

            return argument?.ToString() ?? string.Empty;
        }

        private static string ApplyLevelFormat(this string level) =>
            $"<{level.ToUpper()}>";

        private static string ApplyDateFormat(this DateTime dateTime, DateType dateType) =>
            dateTime.ToString(dateType.GetFormat());

        private static string GetFormat(this DateType dateType)
        {
            switch (dateType)
            {
                case DateType.DateTime: return DateTimeFormat;
                case DateType.Date: return DateFormat;
                case DateType.Time: return TimeFormat;
                default: return string.Empty;
            }
        }

        private static string ApplyCallerFormat(this string callerName) =>
            $"{callerName.Split(".").LastOrDefault()}";

        private static string ApplyExceptionFormat(this Exception exception) =>
            $"Exception: {exception.ToString()}";
    }
}