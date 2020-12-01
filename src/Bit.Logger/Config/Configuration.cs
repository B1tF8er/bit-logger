namespace Bit.Logger.Config
{
    using Enums;
    using FormatProviders;
    using System;
    using System.Text;
    using static Enums.DateType;
    using static Enums.Level;
    using static Enums.ShowLevel;
    using static Helpers.StringExtensions;

    public class Configuration : IConfiguration
    {
        public DateType DateTypeFormat { get; set; } = DateTimeIso;

        public ShowLevel ShowLevel { get; set; } = Yes;

        public Level Level { get; set; } = Information;

        public IFormatProvider FormatProvider { get; set; } = new DefaultFormatProvider();

        private string format = default;

        public string Format
        {
            get => format is null
                ? GetDefaultFormat()
                : format;
            set => format = value.IsNullOrEmptyOrWhiteSpace()
                ? throw new ArgumentNullException(nameof(format))
                : value;
        }

        public int BufferSize { get; set; } = 0;

        private string databaseLogLocation = default;

        public string DatabaseLogLocation
        {
            get => databaseLogLocation is null
                ? AppDomain.CurrentDomain.BaseDirectory
                : databaseLogLocation;
            set => databaseLogLocation = value.IsNullOrEmptyOrWhiteSpace()
                ? throw new ArgumentNullException(nameof(databaseLogLocation))
                : value;
        }

        private string fileLogLocation = default;

        public string FileLogLocation
        {
            get => fileLogLocation is null
                ? AppDomain.CurrentDomain.BaseDirectory
                : fileLogLocation;
            set => fileLogLocation = value.IsNullOrEmptyOrWhiteSpace()
                ? throw new ArgumentNullException(nameof(fileLogLocation))
                : value;
        }

        private string GetDefaultFormat() =>
            new StringBuilder()
                .Append(ShowLevel.Equals(Yes) ? "{0:" + Token.Level + "} " : string.Empty)
                .Append("{1:" + DateTypeFormat.ToString() + "} ")
                .Append("[{2:" + Token.Caller + "}::{3:" + Token.Method + "}] ")
                .Append("{4:" + Token.Message + "} ")
                .Append("{5:" + Token.Exception + "}")
                .ToString();

        public override string ToString() => $"Level:{Level}, Format:{Format}";
    }
}
