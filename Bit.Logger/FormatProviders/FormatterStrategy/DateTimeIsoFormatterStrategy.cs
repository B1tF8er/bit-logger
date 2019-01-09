namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System;
    using static Enums.DateType;
    using static Helpers.DateTypeExtensions;

    internal class DateTimeIsoFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var datetime = argument as Nullable<DateTime>;

            return datetime?.ToString(GetFormatFor(DateTimeIso)) ?? string.Empty;
        }
    }
}