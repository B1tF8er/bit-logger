namespace Bit.Logger.Loggers.Database
{
    using Arguments;
    using BulkWriters;
    using Config;
    using static Helpers.LogArgumentsExtensions;

    internal partial class DatabaseLogger
    {
        private void WriteToDatabase(LogArguments args) => LogBuffer
                .Check(args.IsLevelAllowed(Configuration.Level))
                ?.Add(args.ToDatabaseLogUsing(Configuration))
                .Validate()
                ?.Write(BulkWriter.ToDatabaseAsync, kv => kv.Value)
                .Clear();
    }
}