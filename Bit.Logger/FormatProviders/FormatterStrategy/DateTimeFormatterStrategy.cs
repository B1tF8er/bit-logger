namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System;
    using static DateTypeExtensions;

    internal class DateTimeFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var datetime = argument as Nullable<DateTime>;

            return datetime?.ToString(GetFormatFor(DateType.DateTime)) ?? string.Empty;
        }
    }
}