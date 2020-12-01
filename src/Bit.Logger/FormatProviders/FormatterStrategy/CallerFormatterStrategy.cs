namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System.IO;
    using static Helpers.StringExtensions;

    internal class CallerFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var callerName = argument as string;

            if (callerName.IsNullOrEmptyOrWhiteSpace())
                return string.Empty;

            return Path.GetFileNameWithoutExtension(callerName);
        }
    }
}
