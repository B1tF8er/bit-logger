namespace Bit.Logger.Loggers.Database
{
    using Arguments;
    using BulkWriters;
    using Config;
    using static Helpers.LogArgumentsExtensions;

    internal partial class DatabaseLogger
    {
        private void WriteToDatabase(LogArguments logArguments)
        {
            var isLevelAllowed = Configuration.Level <= logArguments.Level;

            if (!isLevelAllowed)
                return;

            LogBuffer
                .Add(logArguments.ToDatabaseLogUsing(Configuration))
                .Validate()
                ?.Write(BulkWriter.ToDatabaseAsync, kv => kv.Value)
                .Clear();
        }
    }
}