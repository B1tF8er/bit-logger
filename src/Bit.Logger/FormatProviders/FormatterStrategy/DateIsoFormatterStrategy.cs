namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System;
    using static Enums.DateType;
    using static Helpers.DateTypeExtensions;

    internal class DateIsoFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var date = argument as Nullable<DateTime>;

            return date?.ToString(GetFormatFor(DateIso)) ?? string.Empty;
        }
    }
}
