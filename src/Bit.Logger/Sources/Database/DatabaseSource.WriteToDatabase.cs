namespace Bit.Logger.Sources.Database
{
    using Arguments;
    using static Helpers.LogArgumentsExtensions;

    internal partial class DatabaseSource
    {
        private void WriteToDatabase(LogArguments logArguments) => logBuffer
            .Check(logArguments.IsLevelAllowed(configuration.Level))
            .Add(logArguments.ToDatabaseLogUsing(configuration))
            .Validate(configuration.BufferSize)
            .Write(databaseBulkWriter.ToDatabaseAsync, kv => kv.Value);
    }
}
