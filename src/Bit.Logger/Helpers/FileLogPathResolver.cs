namespace Bit.Logger.Helpers
{
    using Config;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using static Constants.PathResolver;

    internal class FileLogPathResolver : IFileLogPathResolver
    {
        private readonly List<string> paths;

        public FileLogPathResolver(IConfiguration configuration) =>
            paths = new List<string>
            {
                configuration.FileLogLocation,
                $"{DateTime.Now.ToString(LogNameFormat)}.log"
            };

        public string CurrentLogPath()
        {
            CreateDirectory();
            return Path.Combine(paths.ToArray());
        }

        private void CreateDirectory()
        {
            try
            {
                var directory = Path.GetDirectoryName(Path.Combine(paths.ToArray()));

                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);
            }
            catch
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory);
                paths.Clear();
                paths.Add(AppDomain.CurrentDomain.BaseDirectory);
            }
        }
    }
}
