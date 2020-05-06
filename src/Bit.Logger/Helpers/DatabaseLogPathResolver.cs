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
            var path = Path.Combine(paths);
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            return $"Data Source={Path.GetFullPath(path)}";
        }
    }
}
