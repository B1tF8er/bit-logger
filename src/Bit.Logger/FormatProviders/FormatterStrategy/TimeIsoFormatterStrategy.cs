namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System;
    using static Enums.DateType;
    using static Helpers.DateTypeExtensions;

    internal class TimeIsoFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var time = argument as DateTime?;

            return time?.ToString(TimeIso.GetFormat()) ?? string.Empty;
        }
    }
}
