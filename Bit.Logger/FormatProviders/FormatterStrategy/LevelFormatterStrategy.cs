
namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using static Helpers.StringExtensions;

    internal class LevelFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var level = argument.ToString()?.ToUpper() ?? string.Empty;

            if (level.IsNullOrEmptyOrWhiteSpace())
                return string.Empty;

            return $"<{level}>";
        }
    }
}