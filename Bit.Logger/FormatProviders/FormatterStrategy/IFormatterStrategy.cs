namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    internal interface IFormatterStrategy
    {
        string ApplyFormatTo<TArgument>(TArgument argument);
    }
}