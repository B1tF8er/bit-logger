namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System;
    using static Bit.Logger.Helpers.DateTypeExtensions;
    
    internal class DateFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var date = argument as Nullable<DateTime>;

            return date?.ToString(GetFormatFor(DateType.Date)) ?? string.Empty;
        }
    }
}