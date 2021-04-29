namespace Bit.Logger.Contract
{
    using Config;
    using System.Collections.Generic;

    public interface ILogger : ISource
    {
        List<ISource> Sources { get; }

        ILogger AddConsoleSource(IConsoleConfiguration configuration = default);

        ILogger AddDatabaseSource(IDatabaseConfiguration configuration = default);

        ILogger AddFileSource(IFileConfiguration configuration = default);

        ILogger AddSource(ISource source);

        ILogger AddSources(IEnumerable<ISource> source);
    }
}
