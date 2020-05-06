namespace Bit.Logger.Helpers
{
    using Config;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class DatabaseLogPathResolver : IDatabaseLogPathResolver
    {
        private const string DatabaseName = "logs.db";

        private readonly List<string> paths;

        public DatabaseLogPathResolver(IConfiguration configuration) =>
            paths = new List<string>
            {
                configuration.DatabaseLogLocation,
                DatabaseName
            };

        public string GetConnectionString()
        {
            CreateDirectory();
            return $"Data Source={Path.GetFullPath(Path.Combine(paths.ToArray()))}";
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
