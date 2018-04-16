namespace Bit.Logger.Config
{
    using Bit.Logger.FormatProviders;
    using System;

    public class ConsoleConfiguration : Configuration
    {
        public IFormatProvider FormatProvider { get; set; } = new LoggerFormatProvider();

        public string Format { get; set; } = "{0:level} {1:time} [{2:short}::{3}] {4} {5:exception}";

        public bool ShowColors { get; set; } = false;
    }
}