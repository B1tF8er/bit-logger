namespace Bit.Logger.FormatProviders
{
    using System;

    public class LoggerFormatProvider : IFormatProvider
    {
        public object GetFormat(Type formatType) =>
            formatType == typeof(ICustomFormatter) ? 
                new LoggerCustomFormatter() : 
                null;
    }
}