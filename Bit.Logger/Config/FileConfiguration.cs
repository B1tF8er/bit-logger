namespace Bit.Logger.Config
{
    using Bit.Logger.FormatProviders;
    using System;

    public class FileConfiguration : Configuration
    {
        public IFormatProvider FormatProvider { get; set; } = new LoggerFormatProvider();

        public string Format { get; set; } = "{0:level} {1:datetime} [{2}::{3}] {4} {5:exception}";

        public string FilePath { get; set; } = string.Empty;
    }
}