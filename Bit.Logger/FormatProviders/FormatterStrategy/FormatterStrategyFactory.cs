namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using static Helpers.Tokens;

    internal static class FormatterStrategyFactory
    {
        internal static IFormatterStrategy GetFormatterStrategy(string format)
        {
            IFormatterStrategy formatterStrategy = default;

            if (format == Level)
                formatterStrategy = new LevelFormatterStrategy();

            if (format == DateTime)
                formatterStrategy = new DateTimeFormatterStrategy();

            if (format == Date)
                formatterStrategy = new DateFormatterStrategy();

            if (format == Time)
                formatterStrategy = new TimeFormatterStrategy();

            if (format == Caller)
                formatterStrategy = new CallerFormatterStrategy();

            if (format == Exception)
                formatterStrategy = new ExceptionFormatterStrategy();

            return formatterStrategy;
        }
    }
}