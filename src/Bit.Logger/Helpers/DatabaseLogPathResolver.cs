namespace Bit.Logger.Helpers
{
    using Config;
    using System;
    using System.IO;
    using static Constants.PathResolver;

    public class DatabaseLogPathResolver : IDatabaseLogPathResolver
    {
        private readonly IConfiguration configuration;

        public DatabaseLogPathResolver(IConfiguration configuration) =>
            this.configuration = configuration;

        public string GetCurrentConnectionString()
        {
            var databaseLogName = $"{LogName}_{DateTime.Now.ToString(LogNameFormat)}.db";
            var path = Path.Combine(configuration.DatabaseLogLocation, databaseLogName);
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            return $"Data Source={Path.GetFullPath(path)}";
        }
    }
}
