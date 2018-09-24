namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System;
    using static DateFormatterExtensions;

    internal class TimeFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var time = argument as Nullable<DateTime>;
            
            if (time is null)
                return string.Empty;

            return time?.ToString(GetFormatFor(DateType.Time));
        }
    }
}