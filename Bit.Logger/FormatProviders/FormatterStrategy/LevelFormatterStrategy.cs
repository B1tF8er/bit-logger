namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    internal class LevelFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var level = argument.ToString();

            if (level is null)
                return string.Empty;

            return $"<{level.ToUpper()}>";
        }
    }
}