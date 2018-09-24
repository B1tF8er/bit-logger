namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using System.Linq;

    internal class CallerFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var callerName = argument as string;
            
            if (callerName is null)
                return string.Empty;

            return $"{callerName.Split(".").LastOrDefault()}";
        }
    }
}