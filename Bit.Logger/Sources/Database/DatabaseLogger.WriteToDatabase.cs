namespace Bit.Logger.Sources.Database
{
    using Arguments;
    using Config;
    using Writers;
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