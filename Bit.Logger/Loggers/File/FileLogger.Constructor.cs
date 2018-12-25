namespace Bit.Logger.Loggers.File
{
    using Config;
    using FileBuffer;
    using System;
    using System.Collections.Generic;

    internal partial class FileLogger : ILogger, IConfiguration, IFileBuffer
    {
        public IDictionary<string, string> Logs { get; set; }

        public object Padlock { get; }

        public Configuration Configuration { get; }

        public FileLogger(Configuration configuration)
        {
            Configuration = configuration ?? new Configuration();
            Logs = new Dictionary<string, string>();
            Padlock = this;
        }
    }
}