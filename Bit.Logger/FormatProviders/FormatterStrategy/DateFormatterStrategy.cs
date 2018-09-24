namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System;
    using static DateFormatterExtensions;
    
    internal class DateFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var date = argument as Nullable<DateTime>;

            if (date is null)
                return string.Empty;
            
            return date?.ToString(GetFormatFor(DateType.Date));
        }
    }
}