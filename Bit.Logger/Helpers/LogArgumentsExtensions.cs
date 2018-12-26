namespace Bit.Logger.Helpers
{
    using Config;
    using Enums;
    using Models;
    using Loggers.Arguments;
    using System;
    using static Helpers.DateFormatter;

    internal static class LogArgumentsExtensions
    {
        internal static string ToStringLogUsing(this ref LogArguments args, Configuration configuration)
        {
            return string.Format(configuration.FormatProvider, configuration.Format,
                args.Level,
                DateTime.Now,
                args.ClassName,
                args.MethodName,
                args.Message,
                args.Exception
            ).Trim();
        }

        internal static Log ToDatabaseLogUsing(this ref LogArguments args, Configuration configuration)
        {
            return new Log
            {
                Id = $"{Guid.NewGuid()}",
                Level = configuration.ShowLevel ? args.Level.ToString() : null,
                Message = args.Message,
                Date = GetFormattedDateFrom(configuration.DateTypeFormat),
                Class = args.ClassName,
                Method = args.MethodName,
                Exception = args.Exception?.ToString() ?? null
            };
        }

        internal static bool IsLevelAllowed(this ref LogArguments args, Level level) =>
            level <= args.Level;
    }
}