
namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using static Helpers.StringExtensions;

    internal class LevelFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var level = argument == null ? string.Empty : argument.ToString().ToUpper();

            if (level.IsNullOrEmptyOrWhiteSpace())
                return string.Empty;

            return $"<{level}>";
        }
    }
}
