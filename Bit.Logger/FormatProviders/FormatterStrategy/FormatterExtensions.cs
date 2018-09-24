namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using Bit.Logger.FormatProviders.FormatterStrategy;

    internal static class FormatterExtensions
    {
        internal static string ApplyFormat(this object argument, string format)
        {
            var formatterStrategy = default(IFormatterStrategy);

            if (format == "level")
                formatterStrategy = new LevelFormatterStrategy();

            if (format == "datetime")
                formatterStrategy = new DateTimeFormatterStrategy();

            if (format == "date")
                formatterStrategy = new DateFormatterStrategy();

            if (format == "time")
                formatterStrategy = new TimeFormatterStrategy();

            if (format == "caller")
                formatterStrategy = new CallerFormatterStrategy();

            if (format == "exception")
                formatterStrategy = new ExceptionFormatterStrategy();

            return formatterStrategy?.ApplyFormatTo(argument) ?? argument?.ToString() ?? string.Empty;
        }
    }
}