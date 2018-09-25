namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System.Linq;

    internal class CallerFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var callerName = argument as string;
            
            return callerName?.Split(".").LastOrDefault() ?? string.Empty;
        }
    }
}