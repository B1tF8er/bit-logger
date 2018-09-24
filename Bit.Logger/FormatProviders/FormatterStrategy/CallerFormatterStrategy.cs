namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System.Linq;

    internal class CallerFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var callerName = argument as string;
            
            callerName = callerName?.Split(".").LastOrDefault() ?? string.Empty;

            return callerName;
        }
    }
}