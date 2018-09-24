namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System;
    using static DateFormatterExtensions;

    internal class DateTimeFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var datetime = argument as Nullable<DateTime>;

            if (datetime is null)
                return string.Empty;

            return datetime?.ToString(GetFormatFor(DateType.DateTime));
        }
    }
}