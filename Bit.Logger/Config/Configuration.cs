namespace Bit.Logger.Config
{
    using Enums;
    using FormatProviders;
    using System;
    using System.Text;
    using static Enums.DateType;
    using static Enums.Level;
    using static Helpers.StringExtensions;

    public class Configuration : IConfiguration
    {
        public DateType DateTypeFormat { get; set; } = DateTimeIso;

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
                .Append(ShowLevel ? "{0:" + Token.Level + "} " : string.Empty)
                .Append("{1:"+ DateTypeFormat.ToString() +"} ")
                .Append("[{2:" + Token.Caller + "}::{3:" + Token.Method + "}] ")
                .Append("{4:" + Token.Message + "} ")
                .Append("{5:" + Token.Exception + "}")
                .ToString();
        }

        public override string ToString() => $"Level:{Level}, Format:{Format}";
    }
}