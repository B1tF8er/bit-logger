namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System;
    
    internal class ExceptionFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var exception = argument as Exception;

            if (exception is null)
                return string.Empty;

            return $"Exception: {exception.ToString()}";
        }
    }
}
