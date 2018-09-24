namespace Bit.Logger.FormatProviders
{
    using System;
    using static Bit.Logger.FormatProviders.FormatterExtensions;

    public class DefaultCustomFormatter : ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider formatProvider) =>
            arg.ApplyFormat(format);
    }
}