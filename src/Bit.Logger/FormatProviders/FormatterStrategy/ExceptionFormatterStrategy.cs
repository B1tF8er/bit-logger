namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System;

    internal class ExceptionFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            if (argument is Exception exception)
                return $"Exception: {exception}";

            return string.Empty;
        }
    }
}
