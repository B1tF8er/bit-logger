namespace Bit.Logger.Config
{
    using Enums;
    using FormatProviders;
    using System;
    using System.Text;
    using static Enums.Level;
    using static Enums.ShowLevel;
    using static Helpers.StringExtensions;

    public class Configuration : IConfiguration
    {
        public DateType DateTypeFormat { get; set; }

        public ShowLevel ShowLevel { get; set; }

        public Level Level { get; set; } = Information;

        public IFormatProvider FormatProvider { get; set; } = new DefaultFormatProvider();

        private string format;

        public string Format
        {
            get => format ?? GetDefaultFormat();
            set => format = value.IsNullOrEmptyOrWhiteSpace()
                ? throw new ArgumentNullException(nameof(format))
                : value;
        }

        public int BufferSize { get; set; } = 0;

        private string databaseLogLocation;

        public string DatabaseLogLocation
        {
            get => databaseLogLocation ?? AppDomain.CurrentDomain.BaseDirectory;
            set => databaseLogLocation = value.IsNullOrEmptyOrWhiteSpace()
                ? throw new ArgumentNullException(nameof(databaseLogLocation))
                : value;
        }

        private string fileLogLocation;

        public string FileLogLocation
        {
            get => fileLogLocation ?? AppDomain.CurrentDomain.BaseDirectory;
            set => fileLogLocation = value.IsNullOrEmptyOrWhiteSpace()
                ? throw new ArgumentNullException(nameof(fileLogLocation))
                : value;
        }

        private string GetDefaultFormat() =>
            new StringBuilder()
                .Append(ShowLevel.Equals(Yes) ? "{0:" + Token.Level + "} " : string.Empty)
                .Append("{1:").Append(DateTypeFormat.ToString()).Append("} ")
                .Append("[{2:").Append(Token.Caller).Append("}::{3:").Append(Token.Method).Append("}] ")
                .Append("{4:").Append(Token.Message).Append("} ")
                .Append("{5:").Append(Token.Exception).Append('}')
                .ToString();

        public override string ToString() => $"Level:{Level}, Format:{Format}";
    }
}
