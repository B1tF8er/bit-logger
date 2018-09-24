namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    internal class LevelFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var level = argument.ToString()?.ToUpper() ?? string.Empty;

            return $"<{level}>";
        }
    }
}