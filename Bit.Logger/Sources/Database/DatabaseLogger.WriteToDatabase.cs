namespace Bit.Logger.Sources.Database
{
    using Arguments;
    using Config;
    using Writers;
    using static Helpers.LogArgumentsExtensions;

    internal partial class DatabaseLogger
    {
        private void WriteToDatabase(LogArguments logArguments) => logBuffer
            .Check(logArguments.IsLevelAllowed(configuration.Level))
            ?.Add(logArguments.ToDatabaseLogUsing(configuration))
            .Validate()
            ?.Write(DatabaseBulkWriter.ToDatabaseAsync, kv => kv.Value)
            .Clear();
    }
}
