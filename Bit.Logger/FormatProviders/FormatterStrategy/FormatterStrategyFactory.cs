namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using Enums;
    using static Enums.Token;

    internal static class FormatterStrategyFactory
    {
        internal static IFormatterStrategy GetFormatterStrategy(Token token)
        {
            IFormatterStrategy formatterStrategy = default;

            switch (token)
            {
                case Token.Level: formatterStrategy = new LevelFormatterStrategy(); break;
                case DateTimeIso: formatterStrategy = new DateTimeIsoFormatterStrategy(); break;
                case DateIso: formatterStrategy = new DateIsoFormatterStrategy(); break;
                case TimeIso: formatterStrategy = new TimeIsoFormatterStrategy(); break;
                case Caller: formatterStrategy = new CallerFormatterStrategy(); break;
                case Exception: formatterStrategy = new ExceptionFormatterStrategy(); break;
            }

            return formatterStrategy;
        }
    }
}