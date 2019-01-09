namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System;
    using static Enums.DateType;
    using static Helpers.DateTypeExtensions;

    internal class TimeIsoFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var time = argument as Nullable<DateTime>;
            
            return time?.ToString(GetFormatFor(TimeIso)) ?? string.Empty;
        }
    }
}