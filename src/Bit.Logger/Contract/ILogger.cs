namespace Bit.Logger.Contract
{
    using Config;
    using System.Collections.Generic;

    public interface ILogger : ISource
    {
        List<ISource> Sources { get; }

        ILogger AddConsoleSource(Configuration configuration = default);

        ILogger AddDatabaseSource(Configuration configuration = default);

        ILogger AddFileSource(Configuration configuration = default);

        ILogger AddSource(ISource source);

        ILogger AddSources(IEnumerable<ISource> source);
    }
}
