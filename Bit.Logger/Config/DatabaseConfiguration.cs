namespace Bit.Logger.Config
{
    using Bit.Logger.FormatProviders;
    using System;

    public class DatabaseConfiguration : Configuration
    {
        public string ConnectionString { get; set; } = string.Empty;
    }
}