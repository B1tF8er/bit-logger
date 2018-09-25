namespace Bit.Logger.FormatProviders
{
    using System;
    using static FormatterStrategy.FormatterExtensions;

    public class DefaultCustomFormatter : ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider formatProvider) =>
            arg.ApplyFormat(format);
    }
}