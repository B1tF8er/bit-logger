namespace Bit.Logger.Helpers
{
    using Config;
    using System.Collections.Generic;
    using System.IO;

    public class DatabaseLogPathResolver : IDatabaseLogPathResolver
    {
        private const string DatabaseName = "logs.db";

        private readonly string[] paths;

        public DatabaseLogPathResolver(IConfiguration configuration) =>
            paths = new List<string>
            {
                configuration.DatabaseLogLocation,
                DatabaseName
            }.ToArray();

        public string GetConnectionString()
        {
            CreateDirectory();
            return $"Data Source={Path.GetFullPath(Path.Combine(paths))}";
        }

        private void CreateDirectory()
        {
            var directory = Path.GetDirectoryName(Path.Combine(paths));

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
        }
    }
}
