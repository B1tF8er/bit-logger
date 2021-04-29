namespace Bit.Logger.Config
{
    using System;
    using System.Text;
    using static Helpers.StringExtensions;

    public class DatabaseConfiguration : Configuration, IDatabaseConfiguration
    {
        private string databaseLogLocation;

        public string DatabaseLogLocation
        {
            get => databaseLogLocation ?? AppDomain.CurrentDomain.BaseDirectory;
            set => databaseLogLocation = value.IsNullOrEmptyOrWhiteSpace()
                ? throw new ArgumentNullException(nameof(databaseLogLocation))
                : value;
        }

        public override string ToString() =>
            new StringBuilder(base.ToString())
                .AppendLine($"DatabaseLogLocation: {DatabaseLogLocation}")
                .ToString();
    }
}
