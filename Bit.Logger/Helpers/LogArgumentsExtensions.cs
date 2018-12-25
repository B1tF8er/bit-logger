namespace Bit.Logger.Helpers
{
    using Config;
    using Models;
    using Loggers.Arguments;
    using System;
    using static Helpers.DateFormatter;

    internal static class LogArgumentsExtensions
    {
        internal static string ToStringLogUsing(this LogArguments logArguments, Configuration configuration)
        {
            return string.Format(configuration.FormatProvider, configuration.Format,
                logArguments.Level,
                DateTime.Now,
                logArguments.ClassName,
                logArguments.MethodName,
                logArguments.Message,
                logArguments.Exception
            ).Trim();
        }

        internal static Log ToDatabaseLogUsing(this LogArguments logArguments, Configuration configuration)
        {
            return new Log
            {
                Id = $"{Guid.NewGuid()}",
                Level = configuration.ShowLevel ? logArguments.Level.ToString() : null,
                Message = logArguments.Message,
                Date = GetFormattedDateFrom(configuration.DateTypeFormat),
                Class = logArguments.ClassName,
                Method = logArguments.MethodName,
                Exception = logArguments.Exception?.ToString() ?? null
            };
        }
    }
}