namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using Enums;
    using System;

    internal static class FormatterStrategyExtensions
    {
        internal static string ApplyFormat(this object argument, string format)
        {
            Enum.TryParse<Token>(format, ignoreCase: true, out Token token);
            var formatterStrategy = FormatterStrategyFactory.GetFormatterStrategy(token);
            return formatterStrategy?.ApplyFormatTo(argument) ?? argument?.ToString() ?? string.Empty;
        }
    }
}