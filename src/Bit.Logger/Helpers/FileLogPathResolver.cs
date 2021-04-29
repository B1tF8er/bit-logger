namespace Bit.Logger.Helpers
{
    using Config;
    using System;
    using System.IO;
    using static Constants.PathResolver;

    internal class FileLogPathResolver : IFileLogPathResolver
    {
        private readonly IFileConfiguration configuration;

        public FileLogPathResolver(IFileConfiguration configuration) =>
            this.configuration = configuration;

        public string CurrentLogPath()
        {
            var fileLogName = $"{LogName}_{DateTime.Now.ToString(LogNameFormat)}.log";
            var path = Path.Combine(configuration.FileLogLocation, fileLogName);
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            return path;
        }
    }
}
