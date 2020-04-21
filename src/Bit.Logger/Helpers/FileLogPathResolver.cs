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
            CreateDirectory();
            return Path.Combine(paths);
        }

        private void CreateDirectory()
        {
            var directory = Path.GetDirectoryName(Path.Combine(paths));

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
        }
    }
}
