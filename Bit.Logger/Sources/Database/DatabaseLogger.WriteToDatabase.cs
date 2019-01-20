namespace Bit.Logger.Sources.Database
{
    using Arguments;
    using Config;
    using Writers;
    using static Helpers.LogArgumentsExtensions;

    internal partial class DatabaseLogger
    {
        private void WriteToDatabase(LogArguments args) => logBuffer
            .Check(args.IsLevelAllowed(configuration.Level))
            ?.Add(args.ToDatabaseLogUsing(configuration))
            .Validate()
            ?.Write(DatabaseBulkWriter.ToDatabaseAsync, kv => kv.Value)
            .Clear();
    }
}
