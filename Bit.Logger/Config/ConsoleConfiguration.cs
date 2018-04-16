namespace Bit.Logger.Config
{
    using Bit.Logger.FormatProviders;
    using System;

    public class ConsoleConfiguration : Configuration
    {
        public IFormatProvider FormatProvider { get; set; } = new LoggerFormatProvider();

        private string _format;

        public string Format
        {
            get
            {
                if (!UseCustomFormat)
                {
                    _format = string.Empty;

                    if (ShowLevel)
                        _format += "{0:level}";
                    if (ShowDate && ShowTime)
                        _format += "{1:datetime}";
                    if (ShowDate)
                        _format += "{1:date}";
                    if (ShowTime)
                        _format += "{1:time}";

                    _format += "[{2:short}::{3}] {4} {5:exception}";
                }

                return _format;
            }
            set
            {
                if (string.IsNullOrEmpty(_format) || string.IsNullOrWhiteSpace(_format))
                    throw new ArgumentNullException(nameof(_format));

                _format = value;
            }
        }

        public bool ShowColors { get; set; } = false;
    }
}