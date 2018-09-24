namespace Bit.Logger.Config
{
    using Bit.Logger.FormatProviders;
    using System;

    public class Configuration
    {
        public bool ShowDate { get; set; } = true;

        public bool ShowTime { get; set; } = true;

        public bool ShowLevel { get; set; } = true;

        public Level Level { get; set; } = Level.Information;

        public IFormatProvider FormatProvider { get; set; } = new DefaultFormatProvider();

        private string _format = default(string);

        public string Format
        {
            get
            {
                if (_format == null)
                {
                    _format = string.Empty;

                    if (ShowLevel)
                        _format += "{0:level} ";
                    
                    if (ShowDate && ShowTime)
                        _format += "{1:datetime} ";
                    else if (ShowDate)
                        _format += "{1:date} ";
                    else if (ShowTime)
                        _format += "{1:time} ";

                    _format += "[{2:caller}::{3:method}] {4:message} {5:exception}";
                }

                return _format;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(Format));

                _format = value;
            }
        }

        public override string ToString() => $"Level:{Level}, Format:{Format}";
    }
}