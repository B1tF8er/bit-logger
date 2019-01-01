namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    internal static class FormatterStrategyExtensions
    {
        internal static string ApplyFormat(this object argument, string format)
        {
            var formatterStrategy = FormatterStrategyFactory.GetFormatterStrategy(format);
            return formatterStrategy?.ApplyFormatTo(argument) ?? argument?.ToString() ?? string.Empty;
        }
    }
}