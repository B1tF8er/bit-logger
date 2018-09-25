namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using Enums;
    using System;
    using static Helpers.DateTypeExtensions;

    internal class TimeFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var time = argument as Nullable<DateTime>;
            
            return time?.ToString(GetFormatFor(DateType.Time)) ?? string.Empty;
        }
    }
}