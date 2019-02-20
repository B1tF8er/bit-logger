namespace Bit.Logger.Helpers
{
    using Arguments;
    using Config;
    using Enums;
    using Models;
    using System;
    using System.IO;
    using static Enums.ShowLevel;
    using static Helpers.DateFormatter;

    internal static class LogArgumentsExtensions
    {
        internal static string ToStringLogUsing(this ref LogArguments args, IConfiguration configuration) =>
            string.Format(configuration.FormatProvider, configuration.Format,
                args.Level,
                DateTime.Now,
                args.ClassName,
                args.MethodName,
                args.Message,
                args.Exception
            ).Trim();

        internal static Log ToDatabaseLogUsing(this ref LogArguments args, IConfiguration configuration) =>
            new Log
            {
                Id = $"{Guid.NewGuid()}",
                Level = configuration.ShowLevel.Equals(Yes) ? args.Level.ToString() : null,
                Message = args.Message,
                Date = GetFormattedDateFrom(configuration.DateTypeFormat),
                Class = Path.GetFileNameWithoutExtension(args.ClassName),
                Method = args.MethodName,
                Exception = args.Exception?.ToString() ?? null
            };

        internal static bool IsLevelAllowed(this ref LogArguments args, Level level) =>
            level <= args.Level;
    }
}
