namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System;
    using static Enums.DateType;
    using static Helpers.DateTypeExtensions;

    internal class DateIsoFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var date = argument as DateTime?;

            return date?.ToString(DateIso.GetFormat()) ?? string.Empty;
        }
    }
}
