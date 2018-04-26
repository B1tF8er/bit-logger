namespace Bit.Logger.Loggers.File
{
    using Bit.Logger.Config;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        public Configuration Configuration { get; }

        public FileLogger(Configuration configuration) =>
            Configuration = configuration ?? new Configuration();
    }
}