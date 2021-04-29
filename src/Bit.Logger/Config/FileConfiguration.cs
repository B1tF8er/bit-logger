namespace Bit.Logger.Config
{
    using System;
    using System.Text;
    using static Helpers.StringExtensions;

    public class FileConfiguration : FormatConfiguration, IFileConfiguration
    {
        private string fileLogLocation;

        public string FileLogLocation
        {
            get => fileLogLocation ?? AppDomain.CurrentDomain.BaseDirectory;
            set => fileLogLocation = value.IsNullOrEmptyOrWhiteSpace()
                ? throw new ArgumentNullException(nameof(fileLogLocation))
                : value;
        }

        public override string ToString() =>
            new StringBuilder(base.ToString())
                .AppendLine($"FileLogLocation: {FileLogLocation}")
                .ToString();
    }
}
