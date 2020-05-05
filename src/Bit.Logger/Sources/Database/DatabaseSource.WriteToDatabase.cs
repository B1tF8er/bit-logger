namespace Bit.Logger.Sources.Database
{
    using Arguments;
    using Helpers;

    internal partial class DatabaseSource
    {
        private void WriteToDatabase(LogArguments logArguments) => logBuffer
            .Write(
                logArguments,
                (logArguments, configuration) => logArguments.ToDatabaseLogUsing(configuration),
                databaseBulkWriter.ToDatabaseAsync,
                kv => kv.Value
            );
    }
}
