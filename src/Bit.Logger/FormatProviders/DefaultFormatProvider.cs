namespace Bit.Logger.FormatProviders
{
    using System;

    public class DefaultFormatProvider : IFormatProvider
    {
        public object GetFormat(Type formatType) =>
            formatType == typeof(ICustomFormatter) ? 
                new DefaultCustomFormatter() : 
                null;
    }
}
