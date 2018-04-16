namespace Bit.Logger.Config
{
    using Bit.Logger.FormatProviders;
    using System;

    public class DatabaseConfiguration : Configuration
    {
        public IFormatProvider FormatProvider { get; set; } = new LoggerFormatProvider();

        public string Format { get; set; } = "{0:level} {1:time} [{2}::{3}] {4} {5:exception}";

        public string ConnectionString { get; set; } = string.Empty;
    }
}