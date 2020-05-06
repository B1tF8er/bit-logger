namespace Bit.Logger.Helpers
{
    using Config;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using static Constants.PathResolver;

    internal class FileLogPathResolver : IFileLogPathResolver
    {
        private readonly string[] paths;

        public FileLogPathResolver(IConfiguration configuration) =>
            paths = new List<string>
            {
                configuration.FileLogLocation,
                $"{DateTime.Now.ToString(LogNameFormat)}.log"
            }.ToArray();

        public string CurrentLogPath()
        {
            var path = Path.Combine(paths);
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            return path;
        }
    }
}
