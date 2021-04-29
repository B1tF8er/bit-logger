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
        internal static string ToConsoleLogUsing(this LogArguments args, IConfiguration configuration)
        {
            var consoleConfiguration = configuration as IFormatConfiguration;

            return args.ToFormatedString(
                consoleConfiguration.FormatProvider,
                consoleConfiguration.Format
            );
        }

        internal static Log ToDatabaseLogUsing(this LogArguments args, IConfiguration configuration) =>
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

        internal static string ToFileLogUsing(this LogArguments args, IConfiguration configuration)
        {
            var fileConfiguration = configuration as IFormatConfiguration;

            return args.ToFormatedString(
                fileConfiguration.FormatProvider,
                fileConfiguration.Format
            );
        }

        internal static bool IsLevelAllowed(this LogArguments args, Level level) =>
            level <= args.Level;

        private static string ToFormatedString(this LogArguments args, IFormatProvider formatProvider, string format) =>
            string.Format(
                formatProvider,
                format,
                args.Level.ToString(),
                DateTime.Now,
                args.ClassName,
                args.MethodName,
                args.Message,
                args.Exception
            ).Trim();
    }
}
