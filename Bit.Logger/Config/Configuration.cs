namespace Bit.Logger.Config
{
    using Enums;
    using FormatProviders;
    using FormatProviders.FormatterStrategy;
    using System;
    using System.Text;
    using static Helpers.StringExtensions;
    using static Helpers.Tokens;

    public class Configuration
    {
        public DateType DateTypeFormat { get; set; } = DateType.DateTime;

        public bool ShowLevel { get; set; } = true;

        public Level Level { get; set; } = Level.Information;

        public IFormatProvider FormatProvider { get; set; } = new DefaultFormatProvider();

        private string format = default(string);

        public string Format
        {
            get => format is null ? GetDefaultFormat() : format;
            set => format = value.IsNullOrEmptyOrWhiteSpace() ? throw new ArgumentNullException(nameof(format)) : value;
        }

        public override string ToString() => $"Level:{Level}, Format:{Format}";

        private string GetDefaultFormat()
        {
            var formatBuilder = new StringBuilder();

            return formatBuilder
                .Append(ShowLevel ? "{0:" + Helpers.Tokens.Level + "} " : string.Empty)
                .Append("{1:"+ DateTypeFormat.ToString().ToLower() +"} ")
                .Append("[{2:" + Caller + "}::{3:" + Method + "}] ")
                .Append("{4:" + Message + "} ")
                .Append("{5:" + Helpers.Tokens.Exception + "}")
                .ToString();
        }
    }
}