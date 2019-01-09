namespace Bit.Logger.Config
{
    using Enums;
    using FormatProviders;
    using System;
    using System.Text;
    using static Enums.DateType;
    using static Enums.Level;
    using static Helpers.StringExtensions;
    using static Helpers.Tokens;

    public class Configuration : IConfiguration
    {
        public DateType DateTypeFormat { get; set; } = DateTimeISO;

        public bool ShowLevel { get; set; } = true;

        public Level Level { get; set; } = Information;

        public IFormatProvider FormatProvider { get; set; } = new DefaultFormatProvider();

        private string format = default;

        public string Format
        {
            get => format is null ? GetDefaultFormat() : format;
            set => format = value.IsNullOrEmptyOrWhiteSpace() ? throw new ArgumentNullException(nameof(format)) : value;
        }

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

        public override string ToString() => $"Level:{Level}, Format:{Format}";
    }
}