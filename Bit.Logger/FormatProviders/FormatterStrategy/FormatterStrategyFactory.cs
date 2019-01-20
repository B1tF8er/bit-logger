namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using Enums;
    using System.Collections.Generic;
    using static Enums.Token;

    internal static class FormatterStrategyFactory
    {
        private static readonly IDictionary<Token, IFormatterStrategy> strategies;

        static FormatterStrategyFactory()
        {
            strategies = new Dictionary<Token, IFormatterStrategy>
            {
                { Token.Level, new LevelFormatterStrategy() },
                { DateTimeIso, new DateTimeIsoFormatterStrategy() },
                { DateIso, new DateIsoFormatterStrategy() },
                { TimeIso, new TimeIsoFormatterStrategy() },
                { Caller, new CallerFormatterStrategy() },
                { Exception, new ExceptionFormatterStrategy() }
            };
        }

        internal static IFormatterStrategy GetFormatterStrategy(Token token)
        {
            strategies.TryGetValue(token, out var formatterStrategy);

            return formatterStrategy;
        }
    }
}